using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherServices;
using System.ServiceModel;

namespace WeatherRemoteMonitorStep7
{
    public partial class Form1 : Form
    {
        List<string> cities;
        List<string> countries;
        public Form1()
        {
            cities = new List<string>();
            countries = new List<string>();
            InitializeComponent();
        }

        private void UpdateWeatherConditions()
        {
            List<WeatherConditions> locations = new List<WeatherConditions>();

            NetTcpBinding b = new NetTcpBinding();
            b.Security.Mode = SecurityMode.None;
            Uri tcpUri = new Uri("net.tcp://localhost:8734/weatherservices");
            using (ChannelFactory<IWeatherServices> weatherServiceProxy =
                        new ChannelFactory<IWeatherServices>(b, new EndpointAddress(tcpUri)))
            {
                weatherServiceProxy.Open();
                IWeatherServices weatherService = weatherServiceProxy.CreateChannel();
                int i = 0;
                foreach (var item in cities)
                {
                    WeatherConditions weatherConditions = weatherService.GetWeatherConditions(item, cities[i]);
                    locations.Add(weatherConditions);
                    i++;
                }
                weatherServiceProxy.Close();
            }
            StringBuilder str = new StringBuilder();
            foreach (var item in locations)
            {
                str.Append(item.ToString());
            }
            weatherConditionsTextBox.Text = str.ToString();
        }

        private void label2_Click(object sender, EventArgs e)//non considerare uscito per sbaglio
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            WeatherConditions weather;

            NetTcpBinding b = new NetTcpBinding();
            b.Security.Mode = SecurityMode.None;
            Uri tcpUri = new Uri("net.tcp://localhost:8734/weatherservices");
            using (ChannelFactory<IWeatherServices> weatherServiceProxy =
                        new ChannelFactory<IWeatherServices>(b, new EndpointAddress(tcpUri)))
            {
                weatherServiceProxy.Open();
                IWeatherServices weatherService = weatherServiceProxy.CreateChannel();
                try
                {
                    weather = weatherService.GetWeatherConditions(cityTextBox.Text, countryTextBox.Text);
                    weatherServiceProxy.Close();
                }
                catch (FaultException)
                {
                    MessageBox.Show("Informazioni meteo non disponibili per la località " + cityTextBox.Text + "," + countryTextBox.Text);
                    weather = null;
                }
                finally
                {
                    weatherServiceProxy.Abort();
                }
            }
            UpdateWeatherConditions();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateWeatherConditions();
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            addButton.Visible = true;
            updateButton.Visible = true;
        }
    }
}
