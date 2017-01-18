using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wather
{
    public class Display
    {
        public string Print(string[] sensors)
        {
            StringBuilder ris = new StringBuilder();
            foreach (var element in sensors)
            {
                ris.Append(element);
            }
            return ris.ToString();
        }
    }
}
