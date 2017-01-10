using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class TaxHouse : House, ITaxable
    {
        public TaxHouse(string location, bool inCity, double area, decimal value)
            : base(location,inCity, area, value)
        {
        }

        public decimal TaxValue()
        {
            decimal tax;

            if(inCity == true)
            {
                //tax = (estimatedValue / 1000.0M) * 5M + 5M * (decimal)area;
                tax = ((estimatedValue) / 1000.00M) + 5M * (decimal)area;
            }
            else
            {
                tax = ((estimatedValue)/ 1000.00M) + 1M * (decimal)area;
            }

            return tax;
        }

    }
}
