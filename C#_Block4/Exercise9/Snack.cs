using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class Snack: MenuItem
    {
        public float price { get; set;}
        public Snack(String name,float price):base(name)
        {
            this.Name = name;
            this.price = price;
        }
        public override string printToString()
        {
            String ris = String.Format("{0} - Price:${1} \n",this.Name,this.price);
            return ris;
        }
    }
}
