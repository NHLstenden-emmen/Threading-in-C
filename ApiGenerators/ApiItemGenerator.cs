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

namespace Threading_in_C.ApiGenerators
{
    internal class ApiItemGenerator
    {
        // TODO, first check if rarity is available, if not, use getRarity method
        public static Item Parse()
        {
            Random random = new Random();

            string name = (string)itemJson["name"];
            string type = (string)itemJson["type"];
            EquipmentRarityEnum itemRarity = GetRarity(random.Next(0, 5));
            int value = getValue(itemRarity, random);
            string description = (string)itemJson["description"];
            //List<string> properties =
            //List<string> drawbacks =
            //List<string> requirements =
            string history = (string)itemJson["history"];

            return new Item(name, type, itemRarity, value, description, properties, drawbacks, requirements, history);
        }

        private static int getValue(EquipmentRarityEnum itemRarity, Random random)
        {
            switch(itemRarity)
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
            if (randomRarity < 0 || randomRarity >= Enum.GetNames(typeof(EquipmentRarityEnum)).Length)
            {
                throw new ArgumentException("Invalid rarity value: " + randomRarity);
            }
            return (EquipmentRarityEnum)randomRarity;
        }
    }
}
