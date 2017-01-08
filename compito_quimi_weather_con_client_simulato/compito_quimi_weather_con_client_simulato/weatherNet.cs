using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compito_quimi_weather_con_client_simulato
{
    public class weatherNet
    {
        public Dictionary<string, string[]> list = new Dictionary<string, string[]>();

        public void init()
        {
            /*
            List<string> Canada = new List<string>
            {
                "Toronto", "kentuky", "Cane"
            };

            List<string> Italy = new List <string>
            {
                "Genova", "Napoli", "Sicilia"
            };
            */

            string[] Canada =
            {
                "Toronto", "kentuky", "Cane"
            };

            string[] Italy =
            {
                "Genova", "Napoli", "Sicilia"
            };

            list.Add("Canada", Canada);
            list.Add("Italy", Italy);

            //list.Add("Italy", new string[3] {"Genova", "Napoli", "Sicilia" });
            //list.Add("Canada", new string[3] { "Toronto", "Kentuky", "Cane" })

            initPorperties();
        }

        //random.Next(da, a);
        private double temperature;
        public double Temperature
        {
            get { return     temperature; }
            set { temperature = value; }
        }

        private double humidity;
        public double Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }

        private double pressure;
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        private int wind;
        public int Wind
        {
            get { return wind; }
            set { wind = value; }
        }

        public void initPorperties()
        {
            Random random = new Random();
            Temperature = random.Next(-10, +40);
            Humidity = random.Next(0, 100);
            Pressure = random.Next(0, 90);
            Wind = random.Next(1, 17);
        }
    }
}
