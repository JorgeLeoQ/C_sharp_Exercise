using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalExercise;

namespace WeatherMonitor
{
    public partial class WeatherMonitor : Form
    {
        CurrentWeather weather = new CurrentWeather();
        SingleResult<CurrentWeatherResult> result = new SingleResult<CurrentWeatherResult>();
            
        public WeatherMonitor()
        {
            Text = "Weather Monitor";
            InitializeComponent();
        }

        private void PrintWeather()
        {
            StringBuilder str = new StringBuilder();
            ClientSettings.ApiKey = "ab25de4968aa6a65f4209cd2bed122da";
            result = weather.GetByCityName(city.Text, country.Text);
            if (result.Item != null)
            {
                str.Append("Date: " + result.Item.Date + "\n");
                str.Append(" City, Country: " + result.Item.City + ", " + result.Item.Country + "\n");
                str.Append(" Sky: " + result.Item.Title + ", Description: " + result.Item.Description + "\n");
                str.Append(" Temperature: " + (int)(result.Item.Temp - 273.15) + "°C, T Max: " + (int)(result.Item.TempMax - 273.15) + "°C, T Min: " + (int)(result.Item.TempMin - 273.15) + "°C" + "\n");
                str.Append(" Humidity: " + result.Item.Humidity + "% Windspeed: " + result.Item.WindSpeed + "m/h" + "\n");
            }
            else
            {
                str.Append("You wrote something wrong");
            }

            description.Text = str.ToString();
        }


        private void go_Click(object sender, EventArgs e)
        {
            PrintWeather(); 
        }

        private void city_TextChanged(object sender, EventArgs e)
        {
            go.Enabled = true;
        }
    }
}
