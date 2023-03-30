using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Threading_in_C.CRCalculator;

namespace Threading_in_C.CalculatorCR
{
    public class winrateFormula
    {
        Monster monster = new Monster();
        TeamInfo teamInfo = new TeamInfo();
        List<MonsterCreation> monsters;
        List<CreateCharacter> characters;

        public double getMonsterSpeed()
        {
            double movementspeed = monster.GetTotalMovementspeed(monsters);
            return movementspeed;
        }

        public double getMonsterCR()
        {
            double TotalMonsterCR = monster.CalculatorCRMonster(monsters, characters);
            return TotalMonsterCR;
        }

        public double getAvarageMonsterCR()
        {
            double getMonsters = monster.GetAllMonsters(monsters);
            double MonsterCR = getMonsters / getMonsterCR();
            return MonsterCR;
        }

        public double MonsterFormula()
        {
            double formulaMonster = (getMonsterSpeed()) + (getMonsterCR() * monster.GetAllMonsters(monsters));
            return formulaMonster;
        }

        public double getMovementSpeed()
        {
            double TotalMovementSpeed = teamInfo.GetTotalMovementspeed(characters);
            return TotalMovementSpeed;
        }

        public double getTeamHealth()
        {
            double TeamHealth = teamInfo.GetTotalHitPoints(characters);
            return TeamHealth;
        }

        public double getTeamDamage()
        {
            double TeamDamage = teamInfo.GetTotalDamageOutput(characters);
            return TeamDamage;
        }

        public double TeamFormula()
        {
            double Teamform = teamInfo.GetTotalDamageOutput(characters) + teamInfo.GetTotalHitPoints(characters) + teamInfo.GetTotalMovementspeed(characters) + teamInfo.GetTotalLevel(characters);
            return Teamform;
        }


        public double FormulaWinrate(List<MonsterCreation> monsters, List<CreateCharacter> characters)
        {
            double formula1 = MonsterFormula();
            double formula2 = TeamFormula();
            double calculationStep1 = formula1 / formula2 * 100;
            double calculationStep2 = 100 - calculationStep1;
            return calculationStep2;
        }

        public winrateFormula(List<MonsterCreation> monsters, List<CreateCharacter> characters)
        {
            this.monsters = monsters;
            this.characters = characters;
        }


    }
    //testen voor in de main
    /*static void Main(string[] args) 
                    {
                    List<MonsterCreation> monsters = new List<MonsterCreation>();
                    MonsterCreation goblin = new MonsterCreation();
                    MonsterCreation orc = new MonsterCreation();
                    monsters.Add(new MonsterCreation { name = "Goblin", damageOutput = 8, attackBonus = 2, specialAbilities = 0, armorClass = 12, hitPoints = 20, resistances = 0, immunities = 0, movementSpeed = 50 });
                    monsters.Add(new MonsterCreation { name = "Orc", damageOutput = 6, attackBonus = 1, specialAbilities = 5, armorClass = 15, hitPoints = 40, resistances=0, immunities = 0,movementSpeed = 30 });


                    List<CreateCharacter> characters = new List<CreateCharacter>();
                    CreateCharacter fighter = new CreateCharacter()
                    {
                        hitPoints = 50,
                        armorClass = 18,
                        damagePerRound = 20,
                        specialAbilities = 5,
                        characterLevel = 5,
                        movementSpeed = 30,


                    };
                    CreateCharacter wizard = new CreateCharacter()
                    {

                        hitPoints = 100,
                        armorClass = 20,
                        damagePerRound = 30,
                        specialAbilities = 7,
                        characterLevel = 7,
                        movementSpeed = 40,

                    };
                    characters.Add(fighter);
                    characters.Add(wizard);

                    // Calculate the challenge rating of the monsters
                    Monster monster = new Monster();
                    double cr = monster.CalculatorCRMonster(monsters, characters);
                    Console.WriteLine("The challenge rating of these monsters is: " + cr );
                    var teamInfo = new TeamInfo();
                    // Test the methods of the Monster class
                    Console.WriteLine("Number of monsters: " + monster.GetTotalMonster(monsters));
                    Console.WriteLine("Total damage output: " + teamInfo.GetTotalDamageOutput(characters));
                    Console.WriteLine("Total hit points: " + teamInfo.GetTotalHitPoints(characters));
                    Console.WriteLine("Total movement speed: " + teamInfo.GetTotalMovementspeed(characters));
                    Console.WriteLine("Total special abilities: " + teamInfo.GetSpecialAbilities(characters));

                    // Test the methods of the TeamInfo class
                    Console.WriteLine("Party size: " + teamInfo.GetPartySize(characters));
                    Console.WriteLine("Average character level: " + teamInfo.GetAverageLevel(characters));
                    Console.WriteLine("Total character level: " + teamInfo.GetTotalLevel(characters));

                    winrateFormula formula = new winrateFormula(monsters, characters);
                    double monsterFormulaResult = formula.MonsterFormula();
                    double monsterCR = formula.getMonsterCR();

                    // calculate the win rate using the FormulaWinrate method
                    double winRate = formula.FormulaWinrate(monsters, characters);

                    // display the win rate
                    Console.WriteLine("Win rate: {0}", winRate + "%");

                    Console.ReadKey();

                }
                }*/

}

