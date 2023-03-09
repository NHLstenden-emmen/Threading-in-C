using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Threading_in_C.Entities
{
    internal class NPC : Character
    {
        [XmlElement("Backstory")]
        public string Backstory { get; set; }
        [XmlIgnore]
        public List<string> Traits { get; set; }

        public NPC(string name, int health, int movement, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int ar, int bp, List<string> race, string characterClass, string backstory, List<string> traits)
        {
            Name = name;
            Health = health;
            Movement = movement;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
            AR = ar;
            BP = bp;
            Race = race;
            Class = characterClass;
            Backstory = backstory;
            Traits = traits;
        }
    }
}
