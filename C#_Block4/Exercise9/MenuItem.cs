using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class MenuItem
    {
        public string Name { get; set; }
        public MenuItem(String name)
        {
            this.Name = Name;
        }
        public virtual string printToString()
        {
            return Name;
        }
        static void Main(string[] args)
        {
        }
    }

}
