using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class Beverage:MenuItem
    {
        public float PriceSmall { get; set;}
        public float PriceMedium { get; set; }
        public float PriceLarge { get; set; }
        public Beverage(String name, float priceSmall, float priceMedium, float priceLarge) : base(name)
        {
            this.Name = name;
            this.PriceSmall = priceSmall;
            this.PriceMedium = priceMedium;
            this.PriceLarge = priceLarge;
        }
        public override string printToString()
        {
            String ris = String.Format("{0} - Small:${1}; Medium:${2}; Large:${3} \n", this.Name, this.PriceSmall, this.PriceMedium, this.PriceLarge);
            return ris;
        }
    }
}
