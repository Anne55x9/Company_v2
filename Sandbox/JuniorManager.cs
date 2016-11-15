using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class JuniorManager : Manager
    {
        private int WorkingHours;

        public JuniorManager(string name, int monthlyBaseSalary, int monthlyBonus) 
            : base(name, monthlyBaseSalary, monthlyBonus)
        {
            WorkingHours = 0;
        }

        public void SetWorkingHours(int WorkingHours)
        {
            this.WorkingHours = WorkingHours;
        }

        public override int GetBonusPerMonth()
        {
            return GetBonusPerMonth();
        }

        public override int GetSalaryPerMonth()
        {
            if(WorkingHours < 180)
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
           
            if(WorkingHours < 180)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
