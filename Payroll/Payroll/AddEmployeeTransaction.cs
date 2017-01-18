using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public abstract class AddEmployeeTransaction : Transaction
    {
        private readonly int empid;
        private readonly string name;
        private readonly string address;

        public AddEmployeeTransaction(int empid, string name, string address)
        {
            this.empid = empid;
            this.name = name;
            this.address = address;
        }

        //due metodi astratti che saranno implementati dalle classi derivate
        protected abstract PaymentClassification MakeClassification();
        protected abstract PaymentSchedule MakeSchedule();
        //implemento il metodo dell'interfaccia
        public void Execute()
        {
            //paymentClassificaion ci dice se lìimpiegato è pagato a ora, conuno stipendio fisso oppure a comissione
            PaymentClassification pc = MakeClassification();
            //se vengono pagati ogni venerdì a fine mese oppure ogni 15 gg
            PaymentSchedule ps = MakeSchedule();
            PaymentMethod pm = new HoldMethod();
            Employee e = new Employee(empid, name, address);
            e.Classification = pc;
            e.Schedule = ps;
            e.Schedule = ps;
            e.Method = pm;
            PayrollDatabase.AddEmployee(e);
        }
    }
}
