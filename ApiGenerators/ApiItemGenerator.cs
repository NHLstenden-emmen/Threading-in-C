using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Threading_in_C.Entities;
using Threading_in_C.Equipment;
using Threading_in_C.OpenFiveApi;

namespace Threading_in_C.ApiGenerators
{
    internal class ApiItemGenerator
    {
        // TODO, first check if rarity is available, if not, use getRarity method
        public static Item Parse(string rarity = null)
        {
            Random random = new Random();
            var itemJson = randomItem(random, rarity);

            Console.WriteLine(itemJson);

            string name = (string)itemJson["name"];
            string type = (string)itemJson["type"];

            // If the retrieved item has a rarity, it will be used, else it will be random.
            var rarityToken = itemJson.SelectToken("rarity");
            string itemRarity = (string)rarityToken;
            if (rarityToken == null) itemRarity = GetRarity(random.Next(0, 5));

            int value = getValue(itemRarity, random);
            string description = (string)itemJson["description"];
            List<string> properties = ExtractProperties(itemJson);
            List<string> drawbacks = null; // TODO: See where we can get this from
            List<string> requirements = ExtractRequirements(itemJson, type, random);
            string history = (string)itemJson["history"];

            return new Item(name, type, itemRarity, value, description, properties, drawbacks, requirements, history);
        }

        private static int getValue(string itemRarity, Random random)
        {
            // Based on the rarity, gets a value that fits
            switch (itemRarity)
            {
                case "Common":
                    return random.Next(50, 100);
                case "Uncommon":
                    return random.Next(101, 500);
                case "Rare":
                    return random.Next(501, 5000);
                case "Very Rare":
                    return random.Next(5001, 50000);
                case "Legendary":
                    return random.Next(50000, 1000000);
                case "Artifact":
                    return 0;
                default:
                    return 0;
            }
        }

        private static string GetRarity(int randomRarity)
        {
            // If no rarity is declared, get a random rarity
            String[] rarityList = new string[] { "Common", "Uncommon", "Rare", "Very Rare", "Legendary", "Artifact" };

            // If no random rarity is specified, return null
            return rarityList[randomRarity];
        }

        private static JObject randomItem(Random random, string rarity = null)
        {

            // Declaring every possible type of item, and getting a random one
            string[] itemTypes = new string[] { "armor", "weapons", "magicitems" };
            string itemType = itemTypes[random.Next(itemTypes.Length)];

            // Make the request and return a JArray of the item
            OpenFiveApiRequest apiRequest = new OpenFiveApiRequest();
            string itemResponse; 
            if (rarity != null && itemType == "magicitems") { itemResponse = apiRequest.MakeOpenFiveApiRequest(itemType, null, null, rarity); }
            else { itemResponse = apiRequest.MakeOpenFiveApiRequest(itemType); }
            JObject responseJson = JObject.Parse(itemResponse);
            JArray itemsJson = (JArray)responseJson["results"];

            // Choose a random enemy from the response
            int randomIndex = new Random().Next(0, itemsJson.Count);
            JObject itemJson = (JObject)itemsJson[randomIndex];

            if (itemType == "armor" || itemType == "weapons")
            {
                itemJson["type"] = itemType.Replace("s", "");
            }
            if (itemType != "magicitems")
            {
                itemJson["rarity"] = rarity;
            }

            return itemJson;
        }

        // Possible TO DO: add it so that if no properties are found, you can generate them
        private static List<string> ExtractProperties(JToken itemJson)
        {
            // Gets properties from an item
            JToken propertiesToken = itemJson["properties"];
            if (propertiesToken != null && propertiesToken.Any())
            {
                return ((JArray)propertiesToken).Select(p => (string)p).ToList();
            }
            else
            {
                return new List<string>();
            }
        }

        // Possible TO DO: add it so that if no requirements are found, you can generate them
        // TODO: Improve code
        private static List<string> ExtractRequirements(JToken itemJson, string Type, Random random)
        {
            // Gets requirements from an item
            JToken requirementsToken = null;

            List<string> requirementsList = new List<string>();

            // check if these exist
            requirementsToken = itemJson["requires_attunement"];
            if (requirementsToken != null)
            {
                if (requirementsToken.ToString() == "") { requirementsToken = "Yes"; }
                requirementsList.Add($"Requires Attunement: {requirementsToken}");
            }

            requirementsToken = itemJson["strength_requirement"];
            if (requirementsToken != null)
            {
                if (requirementsToken.ToString() == "") { requirementsToken = random.Next(0, 30); }
                requirementsList.Add($"Strength Requirement: {requirementsToken}");
            }

            requirementsToken = itemJson["category"];
            if (requirementsToken != null)
            {
                requirementsList.Add($"Your character should be able to wield: '{requirementsToken}'");
            }

            // If they do exist, return them in a list
            if (requirementsList.Count > 0)
            {
                return requirementsList;
            }

            return new List<string>();
        }
    }
}
