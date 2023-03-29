using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Threading_in_C.Entities
{
    internal class Enemy : Entity
    {
        [XmlIgnore]
        public float CR { get; set; }
        [XmlElement("CR")]
        public string CRAsText
        {
            get { return CR.ToString(); }
            set { CR = float.Parse(value); }
        }
        [XmlIgnore]
        public int Size { get; set; }
        [XmlElement("Size")]
        public string SizeAsText
        {
            get { return Size.ToString(); }
            set { Size = int.Parse(value); }
        }
        [XmlElement("Type")]
        public string Type { get; set; }
        public Enemy(string name, int health, int movement, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int ar, int bp, float cr, int size, string type)
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
            CR = cr;
            Size = size;
            Type = type;
        }
    }
}
