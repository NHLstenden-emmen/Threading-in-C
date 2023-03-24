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
        public static double CharacterCRCalculator(CreateCharacter character)
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

        public double GetTotalHitPoints(List<CreateCharacter> characters)
        {
            double TotalHitPoints = 0;
            foreach (CreateCharacter character in characters)
            {
                TotalHitPoints += character.hitPoints;
            }
            return TotalHitPoints;
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

        public double CalculatorCR(List<CreateCharacter> characters)
        {
            double CalculatorCR = GetAverageLevel(characters) / GetPartySize(characters) + 0.5 * GetMonsters() + 0.25 * GetTotalDamageOutput(characters) + 0.25 * GetTotalHitPoints(characters)/* + 0.5 * total attack bonusses*/ + GetSpecialAbilities(characters);
            return CalculatorCR;
        }

        public double GetPartySize(List<CreateCharacter> characters)
        {
            return characters.Count;
        }
    }
}

