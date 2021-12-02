using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageUC14
{
    public class logicClass:IShowWage
    {
        public int calculateWage(int wagePerHr, string componyName, int totalWorkingDay, int totalWorkingHour)
        {
            int totalHr = 0, wageOfMonth = 0, workingDays = 1, fullDayWage = 0, halfDayWage = 0, fullDayHr = 20, halfDayHr = 10;
            Random ran = new Random();

            while (workingDays <= totalWorkingDay & totalHr <= totalWorkingHour)
            {
                int valueToCheck = ran.Next(3);
                switch (valueToCheck)
                {
                    case 0:
                        Console.WriteLine("employee of " + componyName + " is absent on " + workingDays);
                        workingDays++;
                        break;
                    case 1:
                        fullDayWage = fullDayWage + (fullDayHr * wagePerHr);
                        workingDays++;
                        totalHr = totalHr + fullDayHr;
                        break;
                    case 2:
                        halfDayWage = halfDayWage + (halfDayHr * wagePerHr);
                        workingDays++;
                        totalHr = totalHr + halfDayHr;
                        break;
                }
            }
            wageOfMonth = fullDayWage + halfDayWage;
            return wageOfMonth;
        }
    }
}
