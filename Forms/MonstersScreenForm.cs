using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private int enemyIndex = 0;
        public MonstersScreenForm()
        {
            InitializeComponent();
        }

        private void RefreshSavedEnemies_Click(object sender, EventArgs e)
        {
            OpenFiveApiRequest.con.Open();

            string retrieveSQL = "SELECT * FROM Enemies";

            // add every enemy in the enemies table to the SavedEnemiesListBox
            // FINISH CODE HERE

            // Add the enemy to the ListBox control
            // enemies.Add(enemy);
            // enemyIndex++;
            // SavedEnemiesListBox.Items.Insert(enemy.enemyIndex, enemy.ToString());

            using (SqlCommand command = new SqlCommand(retrieveSQL, OpenFiveApiRequest.con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Print the values of each column in the current row
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetValue(i));
                        }
                        Console.WriteLine();
                    }
                }
            }

            OpenFiveApiRequest.con.Close();
        }
    }
}
