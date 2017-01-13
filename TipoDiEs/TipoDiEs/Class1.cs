using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDiEs
{
    public class Class1 : IMyInterface
    {
        private string nameOfClass = null;

        public Class1(string nameOfClass)
        {
            this.NameOfClass = nameOfClass;
        }

        public string NameOfClass
        {
            get { return nameOfClass; }
            set { nameOfClass = value; }
        }

        public string FaiQualcosa()
        {
            return NameOfClass;
        }
    }
}
