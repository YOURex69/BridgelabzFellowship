using System;

namespace EmployeeWageForMonth
{
    class Program
    {
        public static void Main(string[] args)
        {
            int isFullTime = 0;
            int isPartTime = 1;
            int isAbsent = 2;
            int empDailyWage = 0;
            int empWagePerHour = 20;
            int empHours = 0;
            int empwage = 0;
            string empStatus = "";
            int workingDays = 20;
            Random rand = new Random();
            int key = rand.Next(0, 3);
            switch(key)
            {
                case 0:
                    empHours = 8;
                    empDailyWage = empHours * empWagePerHour;
                    empStatus = "FullTime";
                    break;

                case 1:
                    empHours = 4;
                    empDailyWage = empHours * empWagePerHour;
                    empStatus = "half-Time";
                    break;

                case 2:
                    empHours = 0;
                    empDailyWage = empHours * empWagePerHour;
                    empStatus = "Absent";
                    break;

            }
            empwage = empDailyWage * workingDays;
            Console.WriteLine("Monthly income is " + empwage + " employee status is " + empStatus);
            Console.ReadKey();
        }
    }
}
