using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageUC14
{
    interface IShowWage
    {
        public int calculateWage(int wagePerHr, string componyName, int totalWorkingDay, int totalWorkingHour);
    }
}
