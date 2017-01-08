using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compito_quimi_weather_con_client_simulato
{
    public partial class Form1 : Form
    {
        Logger Log = new Logger();
        Client ClientWeather = new Client();

        public Form1()
        {
            //Logger Log = new Logger();
            //Client ClientWeather = new Client();

            Log.init();
            Log.log("INIZIAMOOOO");
            InitializeComponent();

            /* Creiamo l'oggetto per salvare countries and cities */
            Dictionary<string, string[]> comboboxPopulite = ClientWeather.GetCitiesByCountries("");

            /* Carichiamo la combobox di countries */
            foreach (var countries in comboboxPopulite.Keys)
            {
                Log.log("Dentro form elemento da mettere nella comboboxcountriues: " +  countries);
                comboBoxCountries.Items.Add(countries);
            }
            string[] lista = new string[100];
            comboboxPopulite.TryGetValue("Canada", out lista);
            Log.log("merdaccia: " + lista[0]);
        }

        private void comboBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Appena cambia lindice popoliamo l'altra comboboxcities */
            comboBoxCities.Items.Clear();
            Log.log("Dentro comboBoxCountries_SelectedIndexChanged country selezionato : " + comboBoxCountries.Text);

            string[] citites =  ClientWeather.GetCities(comboBoxCountries.Text);
            foreach (var city in citites)
            {
                Log.log("Dentro comboBoxCountries_SelectedIndexChanged city dentro forech : " + city);
                comboBoxCities.Items.Add(city);
            }
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Scriviamo le proprietà del meteo */
            weatherNet weather = ClientWeather.GetWeater(comboBoxCountries.Text, comboBoxCities.Text);

            /* Ora abbiamo tutti i dati scriviamoli nella richTextBox */
            Log.log("comboBoxCities_SelectedIndexChanged Scriviamo in richTextBoxWeatherInformation");

            Color[] color =
            {
                Color.Aqua,
                Color.CadetBlue,
                Color.Cornsilk,
                Color.Gold,
                Color.HotPink,
                Color.Lavender,
                Color.Moccasin
            };

            richTextBoxWeatherInformation.SelectionBackColor = color[0];
            richTextBoxWeatherInformation.AppendText("weather information in Country: " + comboBoxCountries.Text);
            Log.log("comboBoxCities_SelectedIndexChanged: " + "weather information in Country: " + comboBoxCountries.Text);
            richTextBoxWeatherInformation.AppendText("\n");

            richTextBoxWeatherInformation.SelectionBackColor = color[0];
            richTextBoxWeatherInformation.AppendText("in City : " + comboBoxCities.Text);
            Log.log("comboBoxCities_SelectedIndexChanged: " + "in City: " + comboBoxCities.Text);
            richTextBoxWeatherInformation.AppendText("\n");

            richTextBoxWeatherInformation.SelectionBackColor = color[0];
            richTextBoxWeatherInformation.AppendText("Temperatures: " + weather.Temperature + " °");
            Log.log("comboBoxCities_SelectedIndexChanged: " + "Temperatures: " + weather.Temperature + " °");
            richTextBoxWeatherInformation.AppendText("\n");

            richTextBoxWeatherInformation.SelectionBackColor = color[0];
            richTextBoxWeatherInformation.AppendText("Humidity: " + weather.Humidity +  "%");
            Log.log("comboBoxCities_SelectedIndexChanged: " + "Humidity: " + weather.Humidity + " %");
            richTextBoxWeatherInformation.AppendText("\n");

            richTextBoxWeatherInformation.SelectionBackColor = color[0];
            richTextBoxWeatherInformation.AppendText("Pressure: " + weather.Pressure + " Pressure");
            Log.log("comboBoxCities_SelectedIndexChanged: " + "Pressure: " + weather.Pressure + " Pressure");
            richTextBoxWeatherInformation.AppendText("\n");

            richTextBoxWeatherInformation.SelectionBackColor = color[0];
            richTextBoxWeatherInformation.AppendText("Wind: " + weather.Wind + " KM");
            Log.log("comboBoxCities_SelectedIndexChanged: " + "Wind: " + weather.Wind + " KM");
            richTextBoxWeatherInformation.AppendText("\n");
        }
    }
}
