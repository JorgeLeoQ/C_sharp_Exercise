using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class TaxBus : Bus, ITaxable
    {
        public TaxBus(int numberOfSeats, int regNumber, decimal value)
            :base(numberOfSeats, regNumber, value)
        {
        }

        public decimal TaxValue()
        {
            decimal tax = (value / 1000M) + 5M * numberOfSeats;
            return tax;
        }
    }
}
