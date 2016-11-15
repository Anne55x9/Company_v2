﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
     abstract class Manager : Employee
    {
        private int monthlyBaseSalary;
        private int monthlyBonus;

        public Manager(string name, int monthlyBaseSalary, int monthlyBonus) 
            : base(name)
        {
            this.monthlyBaseSalary = monthlyBaseSalary;
            this.monthlyBonus = monthlyBonus;
        }        

        public override int GetBonusPerMonth()
        {
            return monthlyBonus;
        }

        public override int GetSalaryPerMonth()
        {
            return monthlyBaseSalary;
        }

        public override bool IsBonusPaidOut()
        {
            return true;
            
          
        }
    }
}
