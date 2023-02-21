using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Threading_in_C.Entities;

namespace Threading_in_C.Players
{
    public class Player : Entity
    {
        public override string ToString()
        {
            return $"{Name} (H: {Health} M: {Movement} STR: {Strength} DEX: {Dexterity} CON: {Constitution} INT: {Intelligence} WIS: {Wisdom} CHA: {Charisma})";
        }
    }
}
