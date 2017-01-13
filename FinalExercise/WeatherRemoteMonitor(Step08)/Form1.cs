using System;
using System.IO;
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

namespace WeatherRemoteMonitor_Step08_
{
    public partial class Form1 : Form
    {
        List<string> cities;
        List<string> countries;
        char[] separators = new char[] { '/' };

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
            saveButton.Visible = true;
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
            if (weather != null)
            {
                if (!(cities.Contains(cityTextBox.Text) || countries.Contains(countryTextBox.Text)))
                {
                    cities.Add(cityTextBox.Text);
                    countries.Add(countryTextBox.Text);
                }
            }
            UpdateWeatherConditions();
        }
        private void SaveConfig()
        {
            if (!File.Exists("configuration.txt"))
            {
                File.Create("configuration.txt");
            }
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < cities.Count; i++)
            {
                result.AppendLine(cities[i] + "/" + countries[i]);
            }
            File.WriteAllText("configuration.txt", result.ToString());
        }
        private void LoadConfig()
        {
            if (File.Exists("configuration.txt"))
            {
                string[] result = File.ReadAllLines("configuration.txt");
                foreach (var line in result)
                {
                    string[] l = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    cities.Add(l[0]);
                    countries.Add(l[1]);
                }
                UpdateWeatherConditions();
                loadButton.Visible = true;
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateWeatherConditions();
        }
      
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            weatherConditionsTextBox.Clear();
            LoadConfig();
        }
        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            addButton.Visible = true;
            updateButton.Visible = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }
    }
}
