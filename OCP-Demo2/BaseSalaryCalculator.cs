using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Demo2
{
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; set; }
        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }
        public abstract double CalculateSalary();
    }
}
