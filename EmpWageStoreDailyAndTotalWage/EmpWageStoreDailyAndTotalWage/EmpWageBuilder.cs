using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmpWageStoreDailyAndTotalWage
{
    public class EmpWageBuilder
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company = "";
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }
        public void computeEmpWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            ArrayList daily_Wage = new ArrayList();
            while (totalEmpHrs < this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                daily_Wage.Add(empHrs * this.empRatePerHour);
                totalEmpHrs += empHrs;
                //Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);

            }

            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            foreach (var elements in daily_Wage)
            {
                Console.WriteLine("Total wage for today is : "+elements);
            }
            Console.WriteLine("Total Emp Wage for :" + company + " is :" + totalEmpWage);
        }

    }
}
