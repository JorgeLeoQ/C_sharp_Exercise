using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class SalaryWorker : Employee
    {
        public SalaryWorker(String empName, Double salaryAnnual) : base(empName)
        {
            this.salary = salaryAnnual;
        }
        public override Double calcPaidCheck()
        {
            Double ris;
            ris = salary/12;
            return ris;
        }
    }
}
