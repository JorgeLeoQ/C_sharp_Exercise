using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherServices;

namespace Step02
{
    public class Log
    {
        public static void SaveLog(WeatherConditions weatherConditions)
        {
            StreamWriter logFile;

            if (!File.Exists("log.txt"))
            {
                logFile = new StreamWriter("log.txt");
            }
            else
            {
                logFile = File.AppendText("log.txt");
            }

            using (logFile)
            {
                logFile.WriteLine(weatherConditions.ToLog());
            }
        }
    }
}
