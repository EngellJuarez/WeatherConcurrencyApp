using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherConcurrencyApp
{
    public partial class WeatherPanel : UserControl
    {
        public WeatherPanel()
        {
            InitializeComponent();
        }

        private void WeatherPanel_Load(object sender, EventArgs e)
        {
        }

        private void WeatherPanel_Load_1(object sender, EventArgs e)
        {
            dtwLon.lblDetail.Text = "Lon";
            dtwLat.lblDetail.Text = "Lat";
            dtwFeelsLike.lblDetail.Text = "Feels_like";
            dtwTempMin.lblDetail.Text = "Temp_min";
            dtwTempMax.lblDetail.Text = "Temp_max";
            dtwPressure.lblDetail.Text = "Pressure";
            dtwHumidity.lblDetail.Text = "Humidity";
            dtwVisibility.lblDetail.Text = "Visibility";
            dtwSpeed.lblDetail.Text = "Speed";
            dtwSunrise.lblDetail.Text = "Sunrise";
            dtwSunset.lblDetail.Text = "Sunset";
            dtwTimeZone.lblDetail.Text = "Timezone";
        }
    }
}
