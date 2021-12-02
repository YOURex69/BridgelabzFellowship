using System;

namespace EmpWageUsingArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] Arr = new int[5];
            int i = 0;
           EmpWageBuilderObject dMart = new EmpWageBuilderObject("dMart", 20, 2, 10);
            EmpWageBuilderObject google = new EmpWageBuilderObject("Google", 20, 2, 10);
            Arr[i]=dMart.computeEmpWage();
            i++;
            Arr[i] = google.computeEmpWage();
            for(int j=0;j<2;j++)
            {
                Console.WriteLine(" Emp wage is " + Arr[j]);
            }
        }
    }
}
