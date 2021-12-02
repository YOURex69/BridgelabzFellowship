using System;
using System.Collections;

namespace EmpWageArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();

            EmpWageBuilderObject dMart = new EmpWageBuilderObject("dMart", 20, 2, 10);
            EmpWageBuilderObject google = new EmpWageBuilderObject("google", 20, 2, 10);
            int ans1=dMart.computeEmpWage();
            int ans2=google.computeEmpWage();
            myList.Add(ans1);
            myList.Add(ans2);
            foreach (int i in myList)
            {
                Console.WriteLine("Emp Wage is "+i);
            }

        }
    }
}
