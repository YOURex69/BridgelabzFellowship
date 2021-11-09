using System;

namespace EmpWageInterface
{
    class Program
    {
        public static void Main(string[] args)
        {
            empWage dmart = new empWage();
            dmart.addCompanyEmpWage("dmart", 20, 2, 10);
            dmart.computeEmpWage();
        }
    }
}
