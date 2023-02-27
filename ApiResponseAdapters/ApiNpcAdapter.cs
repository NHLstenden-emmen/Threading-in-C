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
        public static NPC Parse(string jsonString)
        {
            string name = "test";

            var (randomRace, randomSpeed, randomTraits) = GetRandomRace();

            int health = new Random().Next(401);
            int movement = randomSpeed;
            int strength = new Random().Next(31);
            int dexterity = new Random().Next(31);
            int constitution = new Random().Next(31);
            int intelligence = new Random().Next(31);
            int wisdom = new Random().Next(31);
            int charisma = new Random().Next(31);

            int ar = new Random().Next(31);
            int bp = 0;

            string race = randomRace;
            string characterClass = GetRandomClass();
            string backstory = ""; 
            string traits = randomTraits;

            NPC randomNPC = new NPC(name, health, movement, strength, dexterity, constitution, intelligence, wisdom, charisma, ar, bp, race, characterClass, backstory, traits);
            
            // Returns a NPC
            return randomNPC;
        }

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

        // Returns a tuple containing a random race, its speed, and its traits.
        public static (string race, int speed, string traits) GetRandomRace()
        {
            OpenFiveApiRequest apiRequest = new OpenFiveApiRequest();
            var raceResponse = apiRequest.MakeOpenFiveApiRequest("races");

            var races = new List<string>();
            var parsedResponse = JObject.Parse(raceResponse);

            // Loop through each race 
            foreach (var race in parsedResponse["results"])
            {
                var raceName = (string)race["name"];
                races.Add(raceName);

                // If the race has subraces add it to the list of races.
                if (race["subraces"].Any())
                {
                    foreach (var subrace in race["subraces"])
                    {
                        var subraceName = (string)subrace["name"];
                        races.Add($"{raceName} - {subraceName}");
                    }
                }
            }

            // Select a random race 
            var selectedRace = races[new Random().Next(races.Count)];

            /* Acceses the results, first or default is a LING method to search the array for an object with an equal name to the selected race
            * then checks if a results gets returned, then acceses the speed of the object, defaults to 10 if no speed is found */
            var speed = (int)parsedResponse["results"].FirstOrDefault(r => (string)r["name"] == selectedRace)?["speed"]["walk"];
            var traits = "";

            return (selectedRace, speed, traits);
        }
    }
}
