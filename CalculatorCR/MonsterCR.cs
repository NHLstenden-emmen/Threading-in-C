using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Threading_in_C.CRCalculator
{

    public class MonsterCreation
    {
        public string name;
        public int damageOutput;
        public int attackBonus;
        public int specialAbilities;
        public int armorClass;
        public int hitPoints;
        public int resistances;
        public int immunities;
        public int movementSpeed;
    }
    public class Monster
    {


        public double GetTotalMonster(List<MonsterCreation> monsters)
        {
            return monsters.Count();
        }

        public double GetTotalDamageOutput(List<MonsterCreation> monsters)
        {
            double TotalDamageOutput = 0;
            foreach (MonsterCreation monster in monsters)
            {
                TotalDamageOutput += monster.damageOutput;
            }
            return TotalDamageOutput;
        }
        public double GetSpecialAbilities(List<MonsterCreation> monsters)
        {
            double SpecialAbilities = 0;
            foreach (MonsterCreation monster in monsters)
            {
                SpecialAbilities += monster.specialAbilities;
            }
            return SpecialAbilities;
        }

        public double GetAllMonsters(List<MonsterCreation> monsters)
        {
            return monsters.Count;
        }

        public double GetTotalHitPoints(List<MonsterCreation> monsters)
        {
            double TotalHitPoints = 0;
            foreach (MonsterCreation monster in monsters)
            {
                TotalHitPoints += monster.hitPoints;
            }
            return TotalHitPoints;
        }

        public double GetTotalMovementspeed(List<MonsterCreation> monsters)
        {
            double movementSpeed = 0;
            foreach (MonsterCreation monster in monsters)
            {
                movementSpeed += monster.movementSpeed;
            }
            return movementSpeed;
        }

        public double GetAttackBonus(List<MonsterCreation> monsters)
        {
            double AttackBonus = 0;
            foreach (MonsterCreation monster in monsters)
            {
                AttackBonus += monster.attackBonus;
            }
            return AttackBonus;
        }


        public double CalculatorCRMonster(List<MonsterCreation> monsters, List<CreateCharacter> characters)
        {

            double CalculatorCR = ((0.5 * GetAllMonsters(monsters)) + (0.25 * GetTotalDamageOutput(monsters)) + (0.25 * GetTotalHitPoints(monsters)) + (0.5 * GetAttackBonus(monsters)) + GetSpecialAbilities(monsters)) - (GetAverageLevel(characters) * GetPartySize(characters) + GetSpecialAbilities(characters) - GetPartySize(characters));
            if (CalculatorCR <= 0)
            {
                return 0;
            }
            else
            {
                return CalculatorCR;
            }

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

        public double GetAverageLevel(List<CreateCharacter> characters)
        {
            double sum = 0;

            foreach (CreateCharacter character in characters)
            {
                sum += character.characterLevel;
            }
            return sum / characters.Count;
        }
        public double GetPartySize(List<CreateCharacter> characters)
        {
            return characters.Count;
        }
    }
}
