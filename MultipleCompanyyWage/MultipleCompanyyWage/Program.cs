using System;

namespace MultipleCompanyyWage
{
    class Program
    {
        const int isFullTime = 0;
        const int isHalfTime = 1;
        const int isAbsent = 2;
      
      
        public static void computeWage(string company, int empWagePerHour, int max_day, int max_hours)
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
            Console.WriteLine("Employee wage is " + empWage+" for company "+company);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            computeWage("apple",20,20,400);
            computeWage("microsoft", 10, 20, 8);
            computeWage("google", 25, 20, 100);
        }

    }
}
