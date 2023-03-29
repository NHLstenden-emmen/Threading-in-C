using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading_in_C.Forms
{
    public partial class NpcScreenForm : Form
    {
        private List<NPC> npcs = new List<NPC>();
        private ManualResetEvent threadExitEvent = new ManualResetEvent(false);
        private int numThreads = 0;
        public NpcScreenForm()
        {
            InitializeComponent();
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
        }
    }
}
