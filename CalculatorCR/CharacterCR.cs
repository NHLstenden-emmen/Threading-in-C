using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Threading_in_C.CRCalculator
{
    public class CharacterCR
    {
        public static double CharacterCRCalculator(CreateCharacter character)//Extra CR calculator
        {
            double cr = (character.hitPoints + character.armorClass + character.damagePerRound + character.specialAbilities) / 4.0;
            return Math.Ceiling(cr);
        }
    }
    public class CreateCharacter
    {
        public int hitPoints;
        public int armorClass;
        public int damagePerRound;
        public int specialAbilities;
        public int characterLevel;
        public int movementSpeed;
    }

    public class TeamInfo
    {
        Monster monster = new Monster();
        List<MonsterCreation> monsters = new List<MonsterCreation>();
        public double GetMonsters()
        {
            double getMonster = monster.GetAllMonsters(monsters);
            return getMonster;
        }

        public double GetAverageLevel(List<CreateCharacter> characters)
        {
            double sum = 0;

            foreach (CreateCharacter character in characters)
            {
                sum += character.characterLevel;
            }
            return sum / characters.Count;
        }

        public double GetTotalDamageOutput(List<CreateCharacter> characters)
        {
            double TotalDamageOutput = 0;
            foreach (CreateCharacter character in characters)
            {
                TotalDamageOutput += character.damagePerRound;
            }
            return TotalDamageOutput;
        }

        public double GetTotalLevel(List<CreateCharacter> characters)
        {
            double TotalLevel = 0;
            foreach (CreateCharacter character in characters)
            {
                TotalLevel += character.characterLevel;
            }
            return TotalLevel;
        }

        public double GetTotalHitPoints(List<CreateCharacter> characters)
        {
            double TotalHitPoints = 0;
            foreach (CreateCharacter character in characters)
            {
                TotalHitPoints += character.hitPoints;
            }
            return TotalHitPoints;
        }
        public double GetTotalMovementspeed(List<CreateCharacter> characters)
        {
            double movementSpeed = 0;
            foreach (CreateCharacter createCharacter in characters)
            {
                movementSpeed += createCharacter.movementSpeed;
            }
            return movementSpeed;
        }

        public double GetSpecialAbilities(List<CreateCharacter> characters)
        {
            double SpecialAbilities = 0;
            foreach (CreateCharacter character in characters)
            {
                SpecialAbilities += character.specialAbilities;
            }
            return SpecialAbilities;
        }


        public double GetPartySize(List<CreateCharacter> characters)
        {
            return characters.Count;
        }


    }
}