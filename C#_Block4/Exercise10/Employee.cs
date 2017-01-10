using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class Employee
    {
        private string empName;
        protected Double salary;
        public Employee(String empName)
        {
            this.empName = empName;
        }
        public virtual Double calcPaidCheck()
        {
            return this.salary;
        }
        static void Main(string[] args)
        {
        }
    }
}
