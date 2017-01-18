using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class  ChangeDirectTransaction : ChangeMethodTransaction
    {
        private readonly string bank;
        private readonly string account;
        public ChangeDirectTransaction(int id, string bank, string account)
            : base(id)
        {
            this.bank = bank;
            this.account = account;
        }
        protected override PaymentMethod Method
        {
            get { return new DirectDepositMethod(bank, account); }
        }
    }
}
