using System.IO;
using FinalExercise;

namespace WeatherServices
{
    public class WeatherServices:IWeatherServices
    {
        public string GetLogFile()
        {
            return File.ReadAllText("log.txt");
        }

        public WeatherConditions GetWeatherConditions(string city, string country)
        {
            WeatherConditions result = new WeatherConditions();
            CurrentWeather weather = new CurrentWeather();
            SingleResult<CurrentWeatherResult> obj = new SingleResult<CurrentWeatherResult>();
            ClientSettings.ApiKey = "ab25de4968aa6a65f4209cd2bed122da";
            obj = weather.GetByCityName(city, country);
            result.City = obj.Item.City;
            result.Country = obj.Item.Country;
            result.Date = obj.Item.Date;
            result.Description = obj.Item.Description;
            result.Humidity = obj.Item.Humidity;
            result.Icon = obj.Item.Icon;
            result.Temp = obj.Item.Temp;
            result.TempMax = obj.Item.TempMax;
            result.TempMin = obj.Item.TempMin;
            result.Title = obj.Item.Title;
            result.WindSpeed = obj.Item.WindSpeed;
            return result;
        }
    }
}
