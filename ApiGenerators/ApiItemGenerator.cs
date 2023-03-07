using Newtonsoft.Json.Linq;
using System;
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
            EquipmentRarityEnum itemRarity;
            JToken rarityToken = itemJson.SelectToken("rarity");
            if (rarityToken == null) itemRarity = GetRarity(random.Next(0, 5));
            else itemRarity = (EquipmentRarityEnum)Enum.Parse(typeof(EquipmentRarityEnum), rarityToken.ToString());

            int value = getValue(itemRarity, random);
            string description = (string)itemJson["description"];
            List<string> properties = null;
            List<string> drawbacks = null;
            List<string> requirements = null;
            string history = (string)itemJson["history"];

            return new Item(name, type, itemRarity, value, description, properties, drawbacks, requirements, history);
        }

        private static int getValue(EquipmentRarityEnum itemRarity, Random random)
        {
            // Based on the rarity, gets a value that fits
            switch (itemRarity)
            {
                case EquipmentRarityEnum.Common:
                    return random.Next(50, 100);
                case EquipmentRarityEnum.Uncommon:
                    return random.Next(101, 500);
                case EquipmentRarityEnum.Rare:
                    return random.Next(501, 5000);
                case EquipmentRarityEnum.VeryRare:
                    return random.Next(5001, 50000);
                case EquipmentRarityEnum.Legendary:
                    return random.Next(50000, 1000000);
                case EquipmentRarityEnum.Artifact:
                    return 0;
                default:
                    return 0;
            }
        }

        private static EquipmentRarityEnum GetRarity(int randomRarity)
        {
            // If no rarity is declared, get a random rarity
            if (randomRarity < 0 || randomRarity >= Enum.GetNames(typeof(EquipmentRarityEnum)).Length)
            {
                throw new ArgumentException("Invalid rarity value: " + randomRarity);
            }
            return (EquipmentRarityEnum)randomRarity;
        }

        private static JArray randomItem(Random random)
        {
            // Declaring every possible type of item, and getting a random one
            string[] itemTypes = new string[] { "armor", "weapons", "magicitems" };
            string itemType = itemTypes[random.Next(itemTypes.Length)];

            // Make the request and return a JArray of the item
            OpenFiveApiRequest apiRequest = new OpenFiveApiRequest();
            var itemResponse = apiRequest.MakeOpenFiveApiRequest(itemType);
            JObject responseJson = JObject.Parse(itemResponse);
            JArray itemJson = (JArray)responseJson["results"];

            if (itemType == "armor" || itemType == "weapon")
            {
                JObject typeObj = new JObject();
                typeObj["type"] = itemType;
                itemJson.Insert(0, typeObj);
            }

            return itemJson;
        }
    }
}
