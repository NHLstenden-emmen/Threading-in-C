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
        public static Item Parse()
        {
            Random random = new Random();
            var itemJson = randomItem(random);

            string name = (string)itemJson["name"];
            string type = (string)itemJson["type"];

            // If the retrieved item has a rarity, it will be used, else it will be random.
            var rarityToken = itemJson.SelectToken("rarity");
            string itemRarity = (string)rarityToken;
            if (rarityToken == null) itemRarity = GetRarity(random.Next(0, 5));

            int value = getValue(itemRarity, random);
            string description = (string)itemJson["description"];
            List<string> properties = null;
            List<string> drawbacks = null;
            List<string> requirements = null;
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

        private static JObject randomItem(Random random)
        {
            // Declaring every possible type of item, and getting a random one
            string[] itemTypes = new string[] { "armor", "weapons", "magicitems" };
            string itemType = itemTypes[random.Next(itemTypes.Length)];

            // Make the request and return a JArray of the item
            OpenFiveApiRequest apiRequest = new OpenFiveApiRequest();
            var itemResponse = apiRequest.MakeOpenFiveApiRequest(itemType);
            JObject responseJson = JObject.Parse(itemResponse);
            JArray itemsJson = (JArray)responseJson["results"];

            // Choose a random enemy from the response
            int randomIndex = new Random().Next(0, itemsJson.Count);
            JObject itemJson = (JObject)itemsJson[randomIndex];

            Console.WriteLine(itemJson.ToString());

            Console.WriteLine(itemType.ToString());

            if (itemType == "armor" || itemType == "weapons")
            {
                itemJson["type"] = itemType.Replace("s", "");
            }

            Console.WriteLine(itemJson["type"]);

            return itemJson;
        }
    }
}
