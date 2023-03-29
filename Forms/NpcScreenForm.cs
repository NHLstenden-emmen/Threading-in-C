using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Threading_in_C.ApiResponseAdapters;
using Threading_in_C.Entities;
using Threading_in_C.OpenFiveApi;

namespace Threading_in_C.Forms
{
    public partial class NpcScreenForm : Form
    {
        private List<NPC> npcs = new List<NPC>();
        private ManualResetEvent threadExitEvent = new ManualResetEvent(false);
        private int numThreads = 0;
        private Mutex dbMutex = new Mutex();

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
                SavedNpcsListBox.Items.Add(npc.Name.ToString());
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
        }

        private void CreateThreads(int numThreadsToCreate)
        {
            for (int i = 0; i < numThreadsToCreate; i++)
            {
                Interlocked.Increment(ref numThreads);
                Thread t = new Thread(new ThreadStart(PerformTask));
                t.Start();
            }

            // Wait for all threads to finish executing
            while (numThreads > 0)
            {
                threadExitEvent.WaitOne();
            }

            // Dispose of the ManualResetEvent object
            threadExitEvent.Set();
            using (threadExitEvent)
            {
                // do niks nie
            }
        }


        private void PerformTask()
        {
            // hier npc aanmaken
            NPC npc;
            bool npcExist = true;
            while (npcExist)
            {
                npc = ApiNpcGenerator.Parse();

                dbMutex.WaitOne(); // acquire the mutex
                try
                {
                    npcExist = NpcExistsInDatabase(npc.Name);
                    if (!npcExist)
                    {
                        AddNPCToDatabase(npc);
                    }
                }
                finally
                {
                    dbMutex.ReleaseMutex(); // release the mutex
                }
            }

            // Signal the thread to exit
            Interlocked.Decrement(ref numThreads);
            threadExitEvent.Set();
        }

        private void AddNPCToDatabase(NPC npc)
        {
            OpenFiveApiRequest.con.Open();

            string insertSQL = "INSERT INTO NPCs (Name, Health, Movement, Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma, ArmorRating, Proficiency, Race, Class, Backstory, Traits) VALUES (@Name, @Health, @Movement, @Strength, @Dexterity, @Constitution, @Intelligence, @Wisdom, @Charisma, @ArmorRating, @Proficiency, @Race, @Class, @Backstory, @Traits)";

            using (SqlCommand command = new SqlCommand(insertSQL, OpenFiveApiRequest.con))
            {
                command.Parameters.AddWithValue("@Name", npc.Name);
                command.Parameters.AddWithValue("@Health", npc.Health);
                command.Parameters.AddWithValue("@Movement", npc.Movement);
                command.Parameters.AddWithValue("@Strength", npc.Strength);
                command.Parameters.AddWithValue("@Dexterity", npc.Dexterity);
                command.Parameters.AddWithValue("@Constitution", npc.Constitution);
                command.Parameters.AddWithValue("@Intelligence", npc.Intelligence);
                command.Parameters.AddWithValue("@Wisdom", npc.Wisdom);
                command.Parameters.AddWithValue("@Charisma", npc.Charisma);
                command.Parameters.AddWithValue("@ArmorRating", npc.AR);
                command.Parameters.AddWithValue("@Proficiency", npc.BP);
                command.Parameters.AddWithValue("@Race", npc.Race);
                command.Parameters.AddWithValue("@Class", npc.Class);
                command.Parameters.AddWithValue("@Backstory", npc.Backstory);
                command.Parameters.AddWithValue("@Traits", string.Join(";", npc.Traits));

                command.ExecuteNonQuery();
            }

            OpenFiveApiRequest.con.Close();
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
    }
}
