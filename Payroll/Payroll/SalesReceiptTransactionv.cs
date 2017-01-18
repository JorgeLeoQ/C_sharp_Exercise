using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class SalesReceiptTransaction : Transaction
    {
        private readonly DateTime date;
        private readonly double amount;
        private readonly int empId;
        public SalesReceiptTransaction(DateTime date,
            double amount, int empId)
        {
            this.date = date;
            this.amount = amount;
            this.empId = empId;
        }
        public void Execute()
        {
            Employee e = PayrollDatabase.GetEmployee(empId);
            if (e != null)
            {
                CommissionedClassification cc =
                    e.Classification as CommissionedClassification;
                if (cc != null)
                    cc.AddSalesReceipt(new SalesReceipt(date, amount));
                else
                    throw new InvalidOperationException(
                        "Tried to add salesreceipt to" +
                        "non-commissioned employee");
            }
            else
                throw new InvalidOperationException(
                "No such employee.");
        }
    }
}
