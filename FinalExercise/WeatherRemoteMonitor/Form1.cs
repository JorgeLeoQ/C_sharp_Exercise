using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using HostWeatherServices;
using FinalExercise;
using WeatherServices;

namespace WeatherRemoteMonitor
{
    public partial class weatherRemote : Form
    {
        public weatherRemote()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e) //per testare: avviare HostWeatherServices in modalià 'no debug'. Assicurarsi che il servizio stia lavorando. Avviare il form in modalità debug
        {
            NetTcpBinding b = new NetTcpBinding();
            b.Security.Mode = SecurityMode.None;
            Uri tcpUri = new Uri("net.tcp://localhost:8734/weatherservices");
            using (ChannelFactory<IWeatherServices> weatherServiceProxy =
                        new ChannelFactory<IWeatherServices>(b, new EndpointAddress(tcpUri)))
            {
                weatherServiceProxy.Open();
                IWeatherServices weatherService = weatherServiceProxy.CreateChannel();
                WeatherConditions weatherConditions = weatherService.GetWeatherConditions(cityTextBox.Text,countryTextBox.Text);
                weatherServiceProxy.Close();
                weatherConditionsTextBox.Text = weatherConditions.ToString(); 
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            goButton.Visible = true;
        }
    }
}
