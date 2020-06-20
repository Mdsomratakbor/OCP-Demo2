using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Demo2
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _salaryCalculators;
        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> salaryCalculators)
        {
            _salaryCalculators = salaryCalculators;
        }

        public double CalculateTotalSalary()
        {
            double totalSalary = 0D;
            foreach (var data in _salaryCalculators)
            {
                totalSalary += data.CalculateSalary();
            }
            return
                totalSalary;
        }
    }
}
