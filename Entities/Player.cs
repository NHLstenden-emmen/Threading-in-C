﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Threading_in_C.Entities;

namespace Threading_in_C.Players
{
    public class Player : Character
    {
        [XmlIgnore]
        public int PlayerIndex;
        [XmlElement("PlayerIndex")]
        public string PlayerIndexAsText
        {
            get { return PlayerIndex.ToString(); }
            set { PlayerIndex = int.Parse(value); }
        }
        public override string ToString()
        {
            return $"{Name} (H: {Health} M: {Movement} STR: {Strength} DEX: {Dexterity} CON: {Constitution} INT: {Intelligence} WIS: {Wisdom} CHA: {Charisma} AR: {AR} BP: {BP})";
        }

        public Player(int playerIndex, string name, int health, int movement, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int ar, int bp, string race, string characterClass)
        {
            PlayerIndex = playerIndex;
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
        }
    }
}
