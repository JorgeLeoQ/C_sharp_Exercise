using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlottingChart
{
    public partial class Form1 : Form
    {
        char[] separators = new char[] { '/' };
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }
        private void PlotChart()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Temperature [K]");
            string[] lines = File.ReadAllLines("log.txt");
            int i = 0;
            foreach (var line in lines)
            {
                string[] param = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (param[0] == citiesComboBox.SelectedItem.ToString())
                {
                    chart1.Series[0].Points.AddXY(i, (int)double.Parse(param[2]));
                    i++;
                }
            }
        }

        private void Initialize()
        {
            chart1.Series.Clear();
            citiesComboBox.Items.Clear();
            string[] lines = File.ReadAllLines("log.txt");
            foreach (var line in lines)
            {
                string[] param = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                if (!citiesComboBox.Items.Contains(param[0]))
                {
                    citiesComboBox.Items.Add(param[0]);
                }
            }
        }

        private void plotChartButton_Click(object sender, EventArgs e)
        {
            PlotChart();
        }
    }
}
