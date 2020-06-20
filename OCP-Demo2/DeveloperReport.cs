using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Demo2
{
    public class DeveloperReport : IDeveloperReport
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public float WorkingHours { get; set; }
        public double HourlyRate { get; set; }

    }
}
