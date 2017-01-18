using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wather
{
    public class Sensor
    {
        public double Value { set; get; }
        public string Model { get; }

        public Sensor(double Value, string Model)
        {
            this.Value = Value;
            this.Model = Model;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Model + ": the value is " + this.Value);
            return sb.ToString();
        }
    }
}
