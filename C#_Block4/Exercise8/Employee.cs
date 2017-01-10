using System;
using Exercise7;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public interface IPayable
    {
        decimal RetriveAmountDue();
        void AddAmountDue(decimal amountDue);
        string PaymentAddress();
    }

    public class Employee : Person, IPayable
    {
        private decimal salary = 0.0m;
        private string mailingAddress = null;

        public decimal Salary
        {
            get
            {
                return salary;
            }
        }
        public string MailingAddress
        {
            get
            {
                return mailingAddress;
            }
        }

        public Employee(string firstName, string lastName, DateTime birthDate, string email, decimal salary, string mailingAddress)
            : base(firstName, lastName, birthDate, email)
        {
            this.salary = salary;
            this.mailingAddress = mailingAddress;
        }
        public Employee(string firstName, string lastName, string email, decimal salary, string mailingAddress)
            :this(firstName, lastName, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), email, salary, mailingAddress)
        { }
        public Employee(string firstName, string lastName, DateTime birthDate, decimal salary, string mailingAddress)
            :this(firstName, lastName, birthDate, "notInsertEmail@error.com", salary, mailingAddress)
        {
        }

        public decimal RetriveAmountDue()
        {
            return Salary;
        }

        public void AddAmountDue(decimal amountDue)
        {
            salary += amountDue;
        }

        public string PaymentAddress()
        {
            return mailingAddress;
        }
    }
}
