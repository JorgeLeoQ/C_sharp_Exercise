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
using System.Xml.Serialization;
using System.IO;
using Weather_non_sputtanato.ServiceReference1;

namespace Weather_non_sputtanato
{
    public partial class Form1 : Form
    {
        Logger logger = new Logger();
        internal Cities.NewDataSet cn;
        public Form1()
        {
            logger.nuovo("Weather_non_sputtanato");

            InitializeComponent();
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.MaxReceivedMessageSize = 20000000;

            EndpointAddress address = new EndpointAddress("http://www.webservicex.com/globalweather.asmx");

            GlobalWeatherSoapClient gwsc = new GlobalWeatherSoapClient(binding, address);

            var cities = gwsc.GetCitiesByCountry("");

            XmlSerializer result = new XmlSerializer(typeof(Cities.NewDataSet));

            cn = (Cities.NewDataSet)result.Deserialize(new StringReader(cities));

            /* Selezioniamo dalla 'tabella/lista' appena creata */
            var Countries = cn.Table.Select(m => m.Country).Distinct();

            /* carichiamo nella combobox tutte le città */
            comboBoxCountries.Items.AddRange(Countries.ToArray());
        }

        private void comboBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rr = cn.Table.Where(m => m.Country == comboBoxCountries.Text).Select(c => c.City);

            comboBoxCities.Items.Clear();
            comboBoxCities.Items.AddRange(rr.ToArray());
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress address = new EndpointAddress("http://www.webservicex.com/globalweather.asmx");
            GlobalWeatherSoapClient gwsc = new GlobalWeatherSoapClient(binding, address);

            logger.log(comboBoxCountries.Text);
            logger.log(comboBoxCities.Text);
          
            //var weather = gwsc.GetWeather(comboBoxCities.Text, comboBoxCountries.Text);
            var weather = gwsc.GetWeather(comboBoxCountries.Text, comboBoxCities.Text);

            logger.log(weather);
            logger.log("proviamo a mano '" + gwsc.GetWeather("Canada", "Key/ Lake") + "'");

            if (weather != "Data Not Found")
            {
                richTextBox1.Clear();

                //XmlSerializer result = new XmlSerializer(typeof(CurrentWeather));
                //var w = (CurrentWeather)result.Deserialize(new StringReader(weather));

                //for (int i = 0; w.ItemsElementName.Length; i++)
                //{
                //    richTextBox1.Text += w.ItemElementName[i] + ": " + w.Item[i] + "\r\n";
                //}
            }
            else
            {
                richTextBox1.Clear();
                richTextBox1.Text = "Data Not Found!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxCountries_FormatStringChanged(object sender, EventArgs e)
        {
            //var rr = cn.Table.Where(m => m.Country == comboBoxCountries.Text).Select(c => c.City);

            //comboBoxCountries.Items.Clear();
            //comboBoxCountries.Items.AddRange(rr.ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCounties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
