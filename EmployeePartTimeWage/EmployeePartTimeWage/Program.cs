using System;

namespace EmployeePartTimeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            int isFullTime = 1;
            int isPartTime = 2;
            int empWage = 0;
            int empHours = 0;
            int empRatePerHours = 20;
            string empstatus = "";
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            if(empCheck==isFullTime)
            {
                empHours = 8;
                empstatus = "FullTime";
            }
            else if(empCheck==isPartTime)
            {
                empHours = 4;
                empstatus = "PartTime";
            }
            else
            {
                empHours = 0;
                empstatus = "Absent";
            }

            empWage = empRatePerHours * empHours;
            Console.WriteLine("Employee wage is "+empWage+" Employee is "+empstatus);
            Console.ReadKey();
        }
    }
}
