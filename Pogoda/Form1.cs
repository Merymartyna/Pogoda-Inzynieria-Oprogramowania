using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string APIKeyOWM = "1c7cf377a26c85d4b01e72633bd794f8";
        string APIKeyWA = "7290084853d14fb69e2183402222204";
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using(WebClient web = new WebClient())
            {
                string urlOWM = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&lang=pl&units=metric&appid={1}", TBCity.Text, APIKeyOWM);
                string urlWA = string.Format("http://api.weatherapi.com/v1/current.json?key={0}&q={1}&aqi=yes&lang=pl", APIKeyWA, TBCity);
                var jsonOWM = web.DownloadString(urlOWM);
                Pogoda.root InfoOWM = JsonConvert.DeserializeObject<Pogoda.root>(jsonOWM);

                var jsonWA = web.DownloadString(urlWA);
                PogodaWA.rootWA InfoWA = JsonConvert.DeserializeObject<PogodaWA.rootWA>(jsonWA);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + InfoOWM.weather[0].icon + ".png";
                labDetails.Text = InfoOWM.weather[0].description;
                labSunset.Text = convertdateTime(InfoOWM.sys.sunset).ToShortTimeString();
                labSunrise.Text = convertdateTime(InfoOWM.sys.sunrise).ToShortTimeString();
                labWindSpeed.Text = InfoOWM.wind.speed.ToString();
                labPressure.Text = InfoOWM.main.pressure.ToString();
                labTemp.Text = InfoOWM.main.temp.ToString();

                labTempWA.Text = InfoWA.current.temp_c.ToString();
                labWindWA.Text = InfoWA.current.wind_mph.ToString();
                labPressWA.Text = InfoWA.current.pressure_mb.ToString();

                double TempOWM = double.Parse(InfoOWM.main.temp.ToString());
                double TempWA = double.Parse(InfoWA.current.temp_c.ToString());

                double WindSpeedOWM = double.Parse(InfoOWM.wind.speed.ToString());
                double WindSpeedWA = double.Parse(InfoWA.current.wind_mph.ToString());

                double PressureOWM = double.Parse(InfoOWM.main.pressure.ToString());
                double PressureWA = double.Parse(InfoWA.current.pressure_mb.ToString());

                double MaxTemp = (TempOWM > TempWA) ? TempOWM : TempWA;
                double MinTemp = (TempOWM < TempWA) ? TempOWM : TempWA;
                double SrTemp = ((TempOWM + TempWA) / 2);

                double MaxWindSpeed = (WindSpeedOWM > WindSpeedWA) ? WindSpeedOWM : WindSpeedWA;
                double MinWindSpeed = (WindSpeedOWM < WindSpeedWA) ? WindSpeedOWM : WindSpeedWA;
                double SrWindSpeed = ((WindSpeedOWM + WindSpeedWA) / 2);

                double MaxPressure = (PressureOWM > PressureWA) ? PressureOWM : PressureWA;
                double MinPressure = (PressureOWM < PressureWA) ? PressureOWM : PressureWA;
                double SrPressure = ((PressureOWM + PressureWA) / 2);

                labMaxTemp.Text = MaxTemp.ToString();
                labMinTemp.Text = MinTemp.ToString();
                labSrTemp.Text = SrTemp.ToString();

                labWindSpeedMax.Text = MaxWindSpeed.ToString();
                labWindSpeedMin.Text = MinWindSpeed.ToString();
                labWindSpeedSr.Text = SrWindSpeed.ToString();

                labPressureMax.Text = MaxPressure.ToString();
                labPressureMin.Text = MinPressure.ToString();
                labPressureSr.Text = SrPressure.ToString();
            }
        }
        DateTime convertdateTime(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();
            return day;
        }

        private void labSunrise_Click(object sender, EventArgs e)
        {

        }

        private void switchTo2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Hide();
        }
    }
}
