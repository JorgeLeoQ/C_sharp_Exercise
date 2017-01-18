using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wather
{
    public class Wind : Sensor
    {
        private Direction myDirection;

        public Wind(double Value, string model, Direction myDirection) : base(Value, model)
        {
            this.myDirection = myDirection;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Model + ": the value is " + this.Value + "/n the direction is " + this.myDirection);
            return sb.ToString();
        }
    }
}
