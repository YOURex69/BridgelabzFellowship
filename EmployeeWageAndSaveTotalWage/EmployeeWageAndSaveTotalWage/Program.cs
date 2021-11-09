using System;

namespace EmployeeWageAndSaveTotalWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("dMart", 20, 2, 10);
            dMart.computeEmpWage();
        }
    }
}
