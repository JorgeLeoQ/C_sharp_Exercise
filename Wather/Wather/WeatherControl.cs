using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wather
{
    public class WeatherControl
    {
        public Sensor[] listOfSensors;
        public Display myDisplay;

        public WeatherControl(Sensor[] listOfSensors, Display myDisplay)
        {
            this.listOfSensors = listOfSensors;
            this.myDisplay = myDisplay;
        }
    }
}
