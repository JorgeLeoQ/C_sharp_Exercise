using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compito_quimi_weather_con_client_simulato
{
    class Client
    {
        weatherNet weather = new weatherNet();
        public Dictionary<string, string[]> GetCitiesByCountries(string Countries)
        {
            weather.init();
            return weather.list;
        }

        public weatherNet GetWeater(string coutnry, string city)
        {
            return weather;
        }

        public string[] GetCities (string country)
        {
            string[] Out = new string[100];
            weather.list.TryGetValue(country, out Out);
            return Out;
        }
    }
}
