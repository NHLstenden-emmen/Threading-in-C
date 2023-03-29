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
using Threading_in_C.Entities;
using Threading_in_C.OpenFiveApi;
using Threading_in_C.Players;

namespace Threading_in_C.Forms
{
    public partial class MonstersScreenForm : Form
    {
        private List<Enemy> enemies = new List<Enemy>();
        public MonstersScreenForm()
        {
            InitializeComponent();
            RetrieveEnemiesFromDatabase();
            AddEnemiesToList();
        }

        // Retrieves all the enemies from the db and puts them in the enemies list
        private void RetrieveEnemiesFromDatabase()
        {
            OpenFiveApiRequest.con.Open();
            enemies.Clear();
            SavedEnemiesListBox.Items.Clear();

            string retrieveSQL = "SELECT * FROM Enemies";
            using (SqlCommand command = new SqlCommand(retrieveSQL, OpenFiveApiRequest.con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Enemy enemy = new Enemy
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
                            reader["ChallengeRating"].ToString(),
                            reader["Size"].ToString(),
                            reader["Type"].ToString()
                        );
                        enemies.Add(enemy);
                    }
                }
            }

            OpenFiveApiRequest.con.Close();
        }

        // Displays all the enemies in the enemies list in the list box
        private void AddEnemiesToList()
        {
            foreach (Enemy enemy in enemies)
            {
                // Add the player to the ListBox control
                SavedEnemiesListBox.Items.Add(enemy.ToString());
            }
        }

        private void RefreshSavedEnemies_Click(object sender, EventArgs e)
        {
            RetrieveEnemiesFromDatabase();
            AddEnemiesToList();
        }

        private void GenerateMonsterButton_Click(object sender, EventArgs e)
        {
            SavedEnemiesListBox.Items.Add("test");
            for (int i = 0; i < (int)MonsterAmount.Value; i++)
            {
                SavedEnemiesListBox.Items.Add((int)MonsterAmount.Value);
                //Thread t = new Thread(new ThreadStart(PerformTask));
                //t.Start();
            }
        }

        private void PerformTask()
        {
            // This is where you would put the code for the task
            // that each thread needs to perform
        }
    }
}
