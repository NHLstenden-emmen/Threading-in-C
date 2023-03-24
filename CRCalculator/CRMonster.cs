using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Threading_in_C.CRCalculator.CRCharacter;

namespace Threading_in_C.CRCalculator
{
    internal class CRMonster
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
        }

        public class MonsterCR
        {
            public static double MonsterCRcalculator(MonsterCreation monster)
            {
                double cr = (monster.hitPoints + monster.armorClass + monster.damageOutput + monster.specialAbilities) / 4.0;
                return Math.Ceiling(cr);
            }
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

            public double GetAttackBonus(List<MonsterCreation> monsters)
            {
                double AttackBonus = 0;
                foreach (MonsterCreation monster in monsters)
                {
                    AttackBonus += monster.attackBonus;
                }
                return AttackBonus;
            }

            CRCharacter.TeamInfo character = new CRCharacter.TeamInfo();
            List<CRCharacter.CreateCharacter> characters = new List<CRCharacter.CreateCharacter>();
            public double CalculatorCRMonster(List<MonsterCreation> monsters)
            {
                double averageLevel = character.GetAverageLevel(characters);
                double partySize = character.GetPartySize(characters);
                double CalculatorCR = averageLevel / partySize + 0.5 * GetAllMonsters(monsters) + 0.25 * GetTotalDamageOutput(monsters) + 0.25 * GetTotalHitPoints(monsters) + 0.5 * GetAttackBonus(monsters) + GetSpecialAbilities(monsters);
                return CalculatorCR;
            }
        }
    }
}
