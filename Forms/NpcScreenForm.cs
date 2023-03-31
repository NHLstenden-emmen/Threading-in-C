using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Threading_in_C.ApiResponseAdapters;
using Threading_in_C.Entities;
using Threading_in_C.OpenFiveApi;
using Threading_in_C.Players;

namespace Threading_in_C.Forms
{
    public partial class NpcScreenForm : Form
    {
        private List<NPC> npcs = new List<NPC>();
        private int numThreads = 0;
        private Mutex dbMutex = new Mutex();
        ApiNpcGenerator apiNpcGenerator = new ApiNpcGenerator();    

        public NpcScreenForm()
        {
            InitializeComponent();
            RetrieveNpcsFromDatabase();
            AddNpcsToList();
        }

        // Retrieves all the npcs from the db and puts them in the npcs list
        private void RetrieveNpcsFromDatabase()
        {
            OpenFiveApiRequest.con.Open();
            npcs.Clear();
            SavedNpcsListBox.Items.Clear();

            string retrieveSQL = "SELECT * FROM NPCs";
            using (SqlCommand command = new SqlCommand(retrieveSQL, OpenFiveApiRequest.con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> traits = new List<string>();
                        string[] traitStrings = reader["Traits"].ToString().Split(';');
                        foreach (string traitString in traitStrings)
                        {
                            traits.Add(traitString);
                        }

                        NPC npc = new NPC
                        (
                            reader["Name"].ToString(),
                            (int)reader["Health"],
                            (int)reader["Movement"],
                            (int)reader["Strength"],
                            (int)reader["Dexterity"],
                            (int)reader["Constitution"],
                            (int)reader["Intelligence"],
                            (int)reader["Wisdom"],
                            (int)reader["Charisma"],
                            (int)reader["ArmorRating"],
                            (int)reader["Proficiency"],
                            reader["Race"].ToString(),
                            reader["Class"].ToString(),
                            reader["Backstory"].ToString(),
                            traits
                        );
                        npcs.Add(npc);
                    }
                }
            }

            OpenFiveApiRequest.con.Close();
        }

        // Displays all the npcs in the npcs list in the list box
        private void AddNpcsToList()
        {
            foreach (NPC npc in npcs)
            {
                // Add the player to the ListBox control
                SavedNpcsListBox.Items.Add(npc.ToString());
            }
        }

        private void RefreshSavedNpcs_Click(object sender, EventArgs e)
        {
            RetrieveNpcsFromDatabase();
            AddNpcsToList();
        }
        
        private void GenerateNPCButton_Click(object sender, EventArgs e)
        {
            CreateThreads((int)AmountOfNPCs.Value);
            CleanupThreads();
        }

        private bool NpcExistsInDatabase(string NpcName)
        {
            bool npcExists = false;
            dbMutex.WaitOne(); // acquire the mutex
            try
            {
                OpenFiveApiRequest.con.Open();
                string retrieveSQL = "SELECT * FROM NPCs WHERE Name = @NpcName";
                using (SqlCommand command = new SqlCommand(retrieveSQL, OpenFiveApiRequest.con))
                {
                    command.Parameters.AddWithValue("@NpcName", NpcName);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            npcExists = true;
                        }
                    }
                }
                OpenFiveApiRequest.con.Close();
            }
            finally
            {
                dbMutex.ReleaseMutex(); // release the mutex
            }
            return npcExists;
        }

        // Method that tries to get a unique enemy up to three times
        private void PutNewNpcInDatabase(NPC npc)
        {
            bool npcExist = NpcExistsInDatabase(npc.Name);
            if (!npcExist)
            {
                ApiNpcGenerator.PutNPCInDatabase(npc);
            }
            else
            {
                int attempts = 0;
                NPC newNpc;
                do
                {
                    newNpc = ApiNpcGenerator.Parse();
                    npcExist = NpcExistsInDatabase(newNpc.Name);
                    attempts++;
                } while (npcExist && attempts < 3);

                if (!npcExist)
                {
                    ApiNpcGenerator.PutNPCInDatabase(newNpc);
                }
            }
        }

        private void CreateThreads(int numThreadsToCreate)
        {
            for (int i = 0; i < numThreadsToCreate; i++)
            {
                Interlocked.Increment(ref numThreads);
                ManualResetEventSlim threadExitEvent = new ManualResetEventSlim(false);
                Thread t = new Thread(() => PerformTask(threadExitEvent));
                t.Start();
            }
        }

        private void PerformTask(ManualResetEventSlim threadExitEvent)
        {
            // create enemy
            var npc = ApiNpcGenerator.Parse();
            dbMutex.WaitOne(); // acquire the mutex
            try
            {
                // tries to get a unique enemy up to three times
                PutNewNpcInDatabase(npc);
            }
            finally
            {
                dbMutex.ReleaseMutex(); // release the mutex
            }

            // Signal the thread to exit
            Interlocked.Decrement(ref numThreads);
            threadExitEvent.Set();
        }

        private void CleanupThreads()
        {
            // Wait for all threads to exit
            while (numThreads > 0)
            {
                Thread.Sleep(10);
            }

            if (numThreads == 0)
            {
                RetrieveNpcsFromDatabase();
                AddNpcsToList();
            }
        }

        private void DeleteNPC_Click(object sender, EventArgs e)
        {
            string deleteSQL = "DELETE FROM NPCs";
            using (SqlCommand command = new SqlCommand(deleteSQL, OpenFiveApiRequest.con))
            {
                OpenFiveApiRequest.con.Open();
                command.ExecuteNonQuery();
                OpenFiveApiRequest.con.Close();
            }
            RetrieveNpcsFromDatabase();
            AddNpcsToList();
        }

        private void NpcScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void SavedNpcsListBox_DoubleClick(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex;
            PlayerBoard.instance.placePlaceableOnPossibleTile(npcs[index]);
        }
    }
}
