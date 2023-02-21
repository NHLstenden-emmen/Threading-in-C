using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_in_C.Players
{
    public class Player
    {
        // Defining player attributes
        public string Name { get; set; }
        public int Health { get; set; }
        public int Movement { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public override string ToString()
        {
            return $"{Name} (H: {Health} M: {Movement} STR: {Strength} DEX: {Dexterity} CON: {Constitution} INT: {Intelligence} WIS: {Wisdom} CHA: {Charisma})";
        }
    }
}
