using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using Threading_in_C.Entities;
using Threading_in_C.OpenFiveApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Threading_in_C.ApiResponseAdapters
{
    internal class ApiEnemyGenerator
    {
        // Changes the API response into an enemy
        public static Enemy Parse(int? ChallengeRating = null)
        {
            Random random = new Random();
            OpenFiveApiRequest apiRequest = new OpenFiveApiRequest();
            string enemyResponse;
            if (ChallengeRating != null) { enemyResponse = apiRequest.MakeOpenFiveApiRequest("monsters", null, ChallengeRating); }
            else { enemyResponse = apiRequest.MakeOpenFiveApiRequest("monsters", random.Next(0, 50)); }

            JObject responseJson = JObject.Parse(enemyResponse);
            JArray enemiesJson = (JArray)responseJson["results"];

            // Choose a random enemy from the response
            int randomIndex = new Random().Next(0, enemiesJson.Count);
            JObject enemyJson = (JObject)enemiesJson[randomIndex];

            string name = (string)enemyJson["name"];

            int health = (int)enemyJson["hit_points"];
            int movement = (int)enemyJson["speed"]["walk"];

            int strength = (int)enemyJson["strength"];
            int dexterity = (int)enemyJson["dexterity"];
            int constitution = (int)enemyJson["constitution"];
            int intelligence = (int)enemyJson["intelligence"];
            int wisdom = (int)enemyJson["wisdom"];
            int charisma = (int)enemyJson["charisma"];

            int ar = (int)enemyJson["armor_class"];
            int bp = 0; // TODO consult Kevin to talk about proficiency

            float cr = GetChallengeRating((string)enemyJson["challenge_rating"]);

            int size = GetSizeValue((string)enemyJson["size"]);
            string type = (string)enemyJson["type"];

            // Return the chosen enemy
            return new Enemy(name, health, movement, strength, dexterity, constitution, intelligence, wisdom, charisma, ar, bp, cr, size, type);
        }

        // Defines the size based on a int instead of a string
        private static int GetSizeValue(string sizeString)
        {
            switch (sizeString.ToLower())
            {
                case "tiny": return 1;
                case "small": return 2;
                case "medium": return 3;
                case "large": return 4;
                case "huge": return 5;
                case "gargantuan": return 6;
                default: return 0;
            }
        }

        // A method to calculate the CR, since the API gives the CR in values like 1/2, 1/4 etc.
        public static float GetChallengeRating(string challengeRating)
        {
            float cr;

            // Try to parse the challengeRating string as a float
            if (float.TryParse(challengeRating, out cr))
            {
                return cr;
            }
            else
            {
                // If the challengeRating is "1/2", "1/4", "1/8", etc split the string 
                string[] parts = challengeRating.Split('/');
                int numerator = int.Parse(parts[0]);
                int denominator = int.Parse(parts[1]);

                // Calculate the float value of the fraction
                cr = (float)numerator / (float)denominator;

                return cr;
            }
        }


        public SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath.Replace("bin\\Debug", "DungeonDB.mdf;Integrated Security=True"));

        public void PutEnemyInDatabase(Enemy enemy)
        {
            con.Open();

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;
                command.CommandText = "INSERT INTO [Enemies] " +
                                      "([Name], [Health], [Movement], [Strength], [Dexterity], [Constitution], [Intelligence], [Wisdom], [Charisma], [ArmorRating], [Proficiency], [Size], [Type], [ChallengeRating]) " +
                                      "VALUES (@Name, @Health, @Movement, @Strength, @Dexterity, @Constitution, @Intelligence, @Wisdom, @Charisma, @ArmorRating, @Proficiency, @Size, @Type, @ChallengeRating)";

                command.Parameters.AddWithValue("@Name", enemy.Name);
                command.Parameters.AddWithValue("@Health", enemy.Health);
                command.Parameters.AddWithValue("@Movement", enemy.Movement);
                command.Parameters.AddWithValue("@Strength", enemy.Strength);
                command.Parameters.AddWithValue("@Dexterity", enemy.Dexterity);
                command.Parameters.AddWithValue("@Constitution", enemy.Constitution);
                command.Parameters.AddWithValue("@Intelligence", enemy.Intelligence);
                command.Parameters.AddWithValue("@Wisdom", enemy.Wisdom);
                command.Parameters.AddWithValue("@Charisma", enemy.Charisma);
                command.Parameters.AddWithValue("@ArmorRating", enemy.AR);
                command.Parameters.AddWithValue("@Proficiency", enemy.BP);
                command.Parameters.AddWithValue("@Size", enemy.Size);
                command.Parameters.AddWithValue("@Type", enemy.Type);
                command.Parameters.AddWithValue("@ChallengeRating", enemy.CR);

                command.ExecuteNonQuery();
            }
        }
    }
}
