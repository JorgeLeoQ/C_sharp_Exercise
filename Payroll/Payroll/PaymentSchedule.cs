using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public interface PaymentSchedule
    {
        bool IsPayDate(DateTime payDate);
        DateTime GetPayPeriodStartDate(DateTime date);
    }
}
