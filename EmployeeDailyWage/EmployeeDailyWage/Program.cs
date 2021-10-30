using System;

namespace EmployeeDailyWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            int isFullTime = 1;
            int wagePerHour = 20;
            int fullDayHour=0;
            int employeeTotalWage=0;
            string employeeStatus = "";
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if(empCheck==isFullTime)
            {
                fullDayHour = 8;
                employeeStatus = "Present";
            }
            else
            {
                fullDayHour = 0;
                employeeStatus = "Absent";
            }

            employeeTotalWage = fullDayHour * wagePerHour;
            Console.WriteLine("Employee wage is " + employeeTotalWage+" Employee is "+employeeStatus);
            Console.ReadKey();
        }
    }
}
