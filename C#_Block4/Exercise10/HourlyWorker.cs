using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class HourlyWorker : Employee
    {
        private int hoursWork { get; set; }
        public HourlyWorker(String empName, Double salaryPerHours, int hoursWork) : base(empName)
        {
            this.hoursWork = hoursWork;
            salary = salaryPerHours;
        }
        public override Double calcPaidCheck()
        {
            return salary * hoursWork;
        }
    }
}
