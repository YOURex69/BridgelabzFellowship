using System;

namespace EmpWageStoreDailyAndTotalWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilder dMart = new EmpWageBuilder("dMart", 20, 20, 200);
            dMart.computeEmpWage();
        }
    }
}
