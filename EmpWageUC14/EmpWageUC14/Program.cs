using System;

namespace EmpWageUC14
{
    class Program
    {
        static void Main(string[] args)
        {
            logicClass obj = new logicClass();

            int accentureWage = obj.calculateWage(150, "Accenture", 20, 200);
            int InfosysWage = obj.calculateWage(120, "Infosys", 26, 300);
            int TCSWage = obj.calculateWage(130, "TCS", 30, 240);

            Console.WriteLine("wage of Accenture company's employee " + accentureWage);
            Console.WriteLine("wage of Infosys company's employee   " + InfosysWage);
            Console.WriteLine("wage of TCS company's employee       " + TCSWage);
        }
    }
}
