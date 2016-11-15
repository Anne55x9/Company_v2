using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class SeniorManager : Manager
    {
        private int performanceLevel;
     
        public SeniorManager(string name, int monthlyBaseSalary, int monthlyBonus) 
            : base(name, monthlyBaseSalary, monthlyBonus)
        {
            performanceLevel = 0;
        }

       

        public void SetPerformancelevel(int performanceLevel)
        {
            this.performanceLevel = performanceLevel;
        }

        public override int GetBonusPerMonth()
        {
            return base.GetBonusPerMonth();
        }

        public override int GetSalaryPerMonth()
        {
            if(performanceLevel < 6)
            {
                return base.GetSalaryPerMonth();
            }
            else
            {
                return (base.GetSalaryPerMonth() + base.GetBonusPerMonth());
            }
           
        }

        public override bool IsBonusPaidOut()
        {

            if (performanceLevel > 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
