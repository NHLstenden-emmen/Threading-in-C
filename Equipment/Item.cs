using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_in_C.Equipment
{
    internal class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Rarity { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public List<string> Properties { get; set; }
        public List<string> Drawbacks { get; set; }
        public List<string> Requirements { get; set; }
        public string History { get; set; }

        public Item(string name, string type, string rarity, int value, string description, List<string> properties, List<string> drawbacks, List<string> requirements, string history)
        {
            Name = name;
            Type = type;
            Rarity = rarity;
            Value = value;
            Description = description;
            Properties = properties;
            Drawbacks = drawbacks;
            Requirements = requirements;
            History = history;
        }
    }
}
