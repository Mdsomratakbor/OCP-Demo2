using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Demo2
{
    public class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport report) : base(report)
        {

        }
        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 102; 

    }
}
