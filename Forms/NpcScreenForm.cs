﻿using System;
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
        }
    }
}
