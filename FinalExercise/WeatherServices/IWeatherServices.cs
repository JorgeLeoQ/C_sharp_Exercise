using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WeatherServices
{
    [ServiceContract]
    public interface IWeatherServices
    {
        [OperationContract]
        string GetLogFile();

        [OperationContract]
        WeatherConditions GetWeatherConditions(string city, string location);
    }
    [DataContract]
    public class WeatherConditions
    {
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public double Temp { get; set; }
        [DataMember]
        public double Humidity { get; set; }
        [DataMember]
        public double TempMax { get; set; }
        [DataMember]
        public double TempMin { get; set; }
        [DataMember]
        public double WindSpeed { get; set; }
        [DataMember]
        public string Icon { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            return str.AppendLine("Date: " + Date + "\n" + "City, Country: " + City + ", " + Country + "\n" + " Sky: " + Title + ", Description: " + Description + "\n" + " Temperature: " + (int)(Temp - 273.15) + "°C, T Max: " + (int)(TempMax - 273.15) + "°C, T Min: " + (int)(TempMin - 273.15) + "°C" + "\n" + " Humidity: " + Humidity + "% Windspeed: " + WindSpeed + "m/h" + "\n").ToString();
        }
        public string ToLog()
        {
            return City + "/" + Country +"/"+ Temp.ToString() + "/" +TempMin.ToString() +"/"+ TempMax.ToString()+"/"+ Date.ToString() +"/" + Title + "/" + Description + "/" + Humidity.ToString() + "/" + WindSpeed.ToString();
        }
    }
}
