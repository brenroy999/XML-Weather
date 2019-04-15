using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.") + "°C";
            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.") + "°C";

            date2.Text = Form1.days[2].date;
            min2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.") + "°C";
            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.") + "°C";

			date3.Text = Form1.days[3].date;
			min3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0.") + "°C";
			max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.") + "°C";
			
			date4.Text = Form1.days[4].date;
			min4.Text = Convert.ToDouble(Form1.days[4].tempLow).ToString("0.") + "°C";
			max4.Text = Convert.ToDouble(Form1.days[4].tempHigh).ToString("0.") + "°C";

			date5.Text = Form1.days[5].date;
			min5.Text = Convert.ToDouble(Form1.days[5].tempLow).ToString("0.") + "°C";
			max5.Text = Convert.ToDouble(Form1.days[5].tempHigh).ToString("0.") + "°C";

			date6.Text = Form1.days[6].date;
			min6.Text = Convert.ToDouble(Form1.days[6].tempLow).ToString("0.") + "°C";
			max6.Text = Convert.ToDouble(Form1.days[6].tempHigh).ToString("0.") + "°C";
		}

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

		private void ForecastScreen_Load(object sender, EventArgs e)
		{

		}
	}
}
