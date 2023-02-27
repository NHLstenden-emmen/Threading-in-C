using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Threading_in_C.Entities;
using Threading_in_C.OpenFiveApi;

namespace Threading_in_C.ApiResponseAdapters
{
    internal class ApiNpcAdapter
    {
        public static List<NPC> Parse(string jsonString)
        {
            JObject responseJson = JObject.Parse(jsonString);
            JArray enemiesJson = (JArray)responseJson["results"];

            List<NPC> npcs = new List<NPC>();
            foreach (JObject enemyJson in enemiesJson)
            {
                string name = (string)enemyJson["name"];

                int health = new Random().Next(401);
                int movement = (int)enemyJson["speed"]["walk"];
                int strength = (int)enemyJson["strength"];
                int dexterity = (int)enemyJson["dexterity"];
                int constitution = (int)enemyJson["constitution"];
                int intelligence = (int)enemyJson["intelligence"];
                int wisdom = (int)enemyJson["wisdom"];
                int charisma = (int)enemyJson["charisma"];

                int ar = (int)enemyJson["armor_class"];
                int bp = 0;// int.Parse(enemyJson["hp"]["formula"].ToString().Split('d')[1]);

                List<string> race = new List<string>();
                string characterClass = GetRandomClass();
                string backstory = "";
                List<string> traits = new List<string>();

                npcs.Add(new NPC(name, health, movement, strength, dexterity, constitution, intelligence, wisdom, charisma, ar, bp, race, characterClass, backstory, traits));
            }

            // Returns a list with enemies
            return npcs;
        }

        // Method to retrieve a random class for the NPC, old method
        /*
        public static string GetRandomClass()
        {
            OpenFiveApiRequest apiRequest = new OpenFiveApiRequest();
            var classResponse = apiRequest.MakeOpenFiveApiRequest("classes");
            JObject responseJson = JObject.Parse(classResponse);
            JArray classes = (JArray)responseJson["results"];

            List<string> availableClasses = new List<string>();
            foreach (JObject availableClass in classes)
            {
                availableClasses.Add((string)availableClass["name"]);
            }

            // generate a random index number within the classes List
            var randomClassIndex = new Random().Next(availableClasses.Count);
            var randomClass = availableClasses[randomClassIndex];
            return randomClass;
        } */

        // New method, now also using LINQ
        public static string GetRandomClass()
        {
            OpenFiveApiRequest apiRequest = new OpenFiveApiRequest();
            var classResponse = apiRequest.MakeOpenFiveApiRequest("classes");
            var classes = JObject.Parse(classResponse)["results"].Select(c => (string)c["name"]).ToList();
            /* Select, Using the Select method to extract the "name" property of each object in the "results" array.
             * is a linq method, aswell as converting the result into a List using ToList. */
            return classes[new Random().Next(classes.Count)];
        }
    }
}
