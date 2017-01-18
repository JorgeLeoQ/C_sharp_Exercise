using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class CommissionedClassification : PaymentClassification
    {
        private readonly double salary;
        private readonly double commissionRate;
        private Hashtable salesReceipts = new Hashtable();

        public CommissionedClassification(double salary, double commissionRate)
        {
            this.salary = salary;
            this.commissionRate = commissionRate;
        }

        public double Salary
        {
            get { return salary; }
        }

        public double CommissionRate
        {
            get { return commissionRate; }
        }

        public void AddSalesReceipt(SalesReceipt receipt)
        {
            salesReceipts[receipt.Date] = receipt;
        }

        public SalesReceipt GetSalesReceipt(DateTime time)
        {
            return salesReceipts[time] as SalesReceipt;
        }

        public override double CalculatePay(Paycheck paycheck)
        {
            double salesTotal = 0;
            foreach (SalesReceipt receipt in salesReceipts.Values)
            {
                if (DateUtil.IsInPayPeriod(receipt.Date,
                    paycheck.PayPeriodStartDate,
                    paycheck.PayPeriodEndDate))
                    salesTotal += receipt.Amount;
            }
            return salary + (salesTotal * commissionRate * 0.01);
        }

        public override string ToString()
        {
            return String.Format("${0} + {1}% sales commission", salary, commissionRate);
        }
    }
}
