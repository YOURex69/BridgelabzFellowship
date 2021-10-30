using System;

namespace EmployeeWageUsingClass
{
    class Program
    {
        const int isFullTime = 0;
        const int isHalfTime = 1;
        const int isAbsent = 2;
        const int empWagePerHour = 20;
       const int max_hours = 200;
       const int max_day = 20;
        public static void computeWage()
        {
            int empWage = 0;
            int empHours = 0;
            int empDays = 0;
            Random rand = new Random();
            while (empDays <= max_day && empHours <= max_hours)
            {
                int key = rand.Next(0, 3);
                switch (key)
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

        public static void Main(string[] args)
        {
            computeWage();
        }

    }
}
