using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Display
    {
        private double size = 0;
        public uint Colors { get; set; }

        public Display(double size, uint colors)
        {
            this.size = size;
            this.Colors = colors;
        }

        public Display(double size) : this(size, 0)
        {
        }

        public double Size
        {
            get
            {
                return this.size;
            }
        }

        public override string ToString()
        {
            StringBuilder MyDisplay = new StringBuilder();
            MyDisplay.AppendFormat("Size: {0}", this.size).AppendLine();
            MyDisplay.AppendFormat("Colors: {0}", this.Colors).AppendLine();
            return MyDisplay.ToString();
        }
    }
}
