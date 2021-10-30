using System;

namespace EmployeeWagesOnCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            const int isFullTime = 0;
            const int isHalfTime = 1;
            const int isAbsent = 2;
            const int empWagePerHour = 20;
            int empWage = 0;
            int max_hours = 200;
            int max_day = 20;
            int empHours = 0;
            int empDays = 0;
            Random rand = new Random();
            while(empDays<=max_day && empHours<=max_hours)
            {
                int key = rand.Next(0,3);
                switch(key)
               {
                    case isFullTime:
                        empHours = empHours + 8;
                        empDays++;
                        break;

                    case isHalfTime:
                        empHours = empHours + 4;
                        empDays++;
                        break;

                    case isAbsent:
                        empDays++;
                        break;
                }

            }
            empWage = empHours * empWagePerHour;
            Console.WriteLine("Employee wage is " + empWage);
            Console.ReadLine();
        }
    }
}
