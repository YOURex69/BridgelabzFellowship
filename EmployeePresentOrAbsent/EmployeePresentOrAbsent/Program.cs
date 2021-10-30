using System;

namespace EmployeePresentOrAbsent
{
    class Program
    {
        public static void Main(string[] args)
        {
            int isFullTime = 1;
            Random random = new Random();//Random object has next method to gernerate random numbers
            int empCheck = random.Next(0, 2);//generates 0 1 
            if(empCheck==isFullTime)
            {
                Console.WriteLine("Employee is present");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Console.ReadKey();
            }

        }
    }
}
