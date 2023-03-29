﻿using System;
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
        List<MonsterCreation> monsters = new List<MonsterCreation>();
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
            double formulaMonster = (getMonsterSpeed()) + (getAvarageMonsterCR() * monster.GetAllMonsters(monsters));
            return formulaMonster;
        }

        TeamInfo teamInfo = new TeamInfo();
        List<CreateCharacter> characters = new List<CreateCharacter>();
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

        public double FormulaWinrate()
        {
            double formula1 = MonsterFormula();
            double formula2 = TeamFormula();
            double calculationStep1 = formula1 / formula2 * 100;
            double calculationStep2 = 100 - calculationStep1;
            return calculationStep2;

        }


    }

}

