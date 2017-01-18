using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wather
{
    public class Pressure : Sensor
    {
        private State myState;
        public Pressure(double Value, string model, State myState) : base(Value, model)
        {
            this.myState = myState;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Model + ": the value is " + this.Value + "/n the state is " + this.myState);
            return sb.ToString();
        }
    }
}
