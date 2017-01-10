using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compito_quimi_weather_con_client_simulato
{
    class Logger
    {
        public void init()
        {
            using (StreamWriter w = File.AppendText("C:\\LoniLove\\logWeather.txt"))
            {
                w.Write("***********************************************************");
                w.WriteLine();
                w.Write("{0} {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
                w.Write("  :{0}", "***** WEATHER COMPITO QUIMIZZZZZZZZZZZ *****");
                w.Write("***********************************************************");
                w.WriteLine();
            }
        }
        public void log(string logMessage)
        {
            using (StreamWriter w = File.AppendText("C:\\LoniLove\\logWeather.txt"))
            {
                w.Write("{0} {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
                w.Write("  :{0}", logMessage);
                w.WriteLine();
            }
        }
    }
}
