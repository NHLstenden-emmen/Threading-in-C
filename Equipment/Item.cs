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
        public string EquipmentRarityEnum { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public List<string> Properties { get; set; }
        public List<string> Drawbacks { get; set; }
        public List<string> Requirements { get; set; }
        public string History { get; set; }
    }
}
