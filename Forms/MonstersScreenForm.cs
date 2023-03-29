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
    }
}
