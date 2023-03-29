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
using Threading_in_C.Players;

namespace Threading_in_C.Forms
{
    public partial class MonstersScreenForm : Form
    {
        private List<Enemy> enemies = new List<Enemy>();
        private ManualResetEvent threadExitEvent = new ManualResetEvent(false);
        private int numThreads = 0;
        private Mutex dbMutex = new Mutex();
        ApiEnemyGenerator apiEnemyGenerator = new ApiEnemyGenerator();

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
            CreateThreads((int)MonsterAmount.Value);
            CleanupThreads();
        }

        private bool EnemyExistsInDatabase(string enemyName)
        {
            bool enemyExists = false;
            dbMutex.WaitOne(); // acquire the mutex
            try
            {
                OpenFiveApiRequest.con.Open();
                string retrieveSQL = "SELECT * FROM Enemies WHERE Name = @EnemyName";
                using (SqlCommand command = new SqlCommand(retrieveSQL, OpenFiveApiRequest.con))
                {
                    command.Parameters.AddWithValue("@EnemyName", enemyName);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            enemyExists = true;
                        }
                    }
                }
                OpenFiveApiRequest.con.Close();
            }
            finally
            {
                dbMutex.ReleaseMutex(); // release the mutex
            }
            return enemyExists;
        }

        // Method that tries to get a unique enemy up to three times
        private void PutNewEnemyInDatabase(Enemy enemy)
        {
            bool enemyExist = EnemyExistsInDatabase(enemy.Name);
            if (!enemyExist)
            {
                apiEnemyGenerator.PutEnemyInDatabase(enemy);
            }
            else
            {
                int attempts = 0;
                Enemy newEnemy;
                do
                {
                    newEnemy = ApiEnemyGenerator.Parse();
                    enemyExist = EnemyExistsInDatabase(newEnemy.Name);
                    attempts++;
                } while (enemyExist && attempts < 3);

                if (!enemyExist)
                {
                    apiEnemyGenerator.PutEnemyInDatabase(newEnemy);
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
            var enemy = ApiEnemyGenerator.Parse();
            dbMutex.WaitOne(); // acquire the mutex
            try
            {
                // tries to get a unique enemy up to three times
                PutNewEnemyInDatabase(enemy);
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
                RetrieveEnemiesFromDatabase();
                AddEnemiesToList();
            }
        }
    }
}
