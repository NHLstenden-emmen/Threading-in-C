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

            int health = new Random().Next(401);
            int movement = 10;
            int strength = new Random().Next(31);
            int dexterity = new Random().Next(31);
            int constitution = new Random().Next(31);
            int intelligence = new Random().Next(31);
            int wisdom = new Random().Next(31);
            int charisma = new Random().Next(31);

            int ar = new Random().Next(31);
            int bp = 0;

            var randomClass = GetRandomClass();
            string race = GetRandomRace();
            string characterClass = randomClass;
            string backstory = "";
            string traits = "";
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

        //TODO get speed, traits and subraces
        public static string GetRandomRace()
        {
            OpenFiveApiRequest apiRequest = new OpenFiveApiRequest();
            var raceResponse = apiRequest.MakeOpenFiveApiRequest("classes");
            var races = JObject.Parse(raceResponse)["results"].Select(c => (string)c["name"]).ToList();
            // add the subraces

            var selectedRace = races[new Random().Next(races.Count)];
            // var speed
            // var traits

            /* Select, Using the Select method to extract the "name" property of each object in the "results" array.
             * is a linq method, aswell as converting the result into a List using ToList. */
            return races[new Random().Next(races.Count)];
        }
    }
}
