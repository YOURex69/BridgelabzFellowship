using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageInterface
{
    public interface IempWage
    {
        public void addCompanyEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth);
        public void computeEmpWage();
       
    }
}
