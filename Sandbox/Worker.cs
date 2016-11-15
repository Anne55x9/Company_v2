using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker: Employee
    {
        private int amountPerHour;
        private int noHourPerMonth;
       
        

        public Worker(string name)
            :base(name)
        {
            this.amountPerHour = 400;
            this.noHourPerMonth = 160;
            
        }

        public override int GetBonusPerMonth()
        {
            return 0;
        }

        public override int GetSalaryPerMonth()
        {
            return amountPerHour*noHourPerMonth;
          
        }

        public override bool IsBonusPaidOut()
        {
             return false;
        }

    }
}
