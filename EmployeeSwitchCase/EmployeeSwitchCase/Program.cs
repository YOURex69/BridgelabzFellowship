using System;

namespace EmployeeSwitchCase
{
    class Program
    {
        public static void Main(string[] args)
        {
            int isFullTime = 1;
            int isPartTime = 2;
            int isAbsent = 3;
            int empWage = 0;
            int empWagePerHour = 20;
            int empHours = 0;
            string empStatus = "";
            Random rand = new Random();
            int key = rand.Next(0, 3);
            switch(key)
            {
                case 0:
                    empHours = 8;
                    empStatus = "FullTime";
                    break;
                case 1:
                    empHours = 4;
                    empStatus = "PartTime";
                    break;
                case 2:
                    empHours = 0;
                    empStatus = "Absent";
                    break;
            }
            empWage = empWagePerHour * empHours;
            Console.WriteLine("Employee wage is " + empWage + " employee status is " + empStatus);
            Console.ReadKey();
        }
    }
}
