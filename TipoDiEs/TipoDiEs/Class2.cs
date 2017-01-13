using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDiEs
{
    public class Class2 : IMyInterface
    {
        private string nameOfClass = null;

        public Class2(string nameOfClass)
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
