using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //Worker FlemmingWorker = new Worker("Flemming");

            //Console.WriteLine($"{FlemmingWorker.GetName()}{FlemmingWorker.GetSalaryPerMonth()}");

            List<Employee> allemployess = new List<Employee>();

            Worker no1 = new Worker("Anne");
            Worker no2 = new Worker("Karen");
            allemployess.Add(no1);
            allemployess.Add(no2);

            JuniorManager Jun1 = new JuniorManager("Sofie", 30000, 5000);
            JuniorManager Jun2 = new JuniorManager("Rikke", 30000, 5000);
            Jun1.SetWorkingHours(160);
            Jun2.SetWorkingHours(200);
            allemployess.Add(Jun1);
            allemployess.Add(Jun2);

            SeniorManager sen1 = new SeniorManager("Lotte", 50000, 10000);
            SeniorManager sen2 = new SeniorManager("Jytte", 50000, 10000);
            sen1.SetPerformancelevel(4);
            sen2.SetPerformancelevel(7);
            allemployess.Add(sen1);
            allemployess.Add(sen2);

            foreach (Employee e in allemployess)
            {
                Console.WriteLine($"Navnet er: {e.GetName()} og lønnen er:{e.GetSalaryPerMonth()} med bonus: {e.IsBonusPaidOut()} ");
            }





            // The LAST line of code should be ABOVE this line
        }
    }
}
