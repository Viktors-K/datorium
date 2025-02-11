using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Drawing;

namespace weatherapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            var cityName = city.Text;
            var requestUrl = $"http://api.weatherapi.com/v1/forecast.xml?key=ecdaff50705e449ab6311843250302&q={cityName}&days=1";

            XDocument doc = XDocument.Load(requestUrl);

            string moonPhs = (string)doc.Descendants("moon_phase").FirstOrDefault();
            string maxT = (string)doc.Descendants("maxtemp_c").FirstOrDefault();
            string minT = (string)doc.Descendants("mintemp_c").FirstOrDefault();
            string hum = (string)doc.Descendants("avghumidity").FirstOrDefault();
            string windSpd = (string)doc.Descendants("wind_kph").FirstOrDefault();
            string baroPrss = (string)doc.Descendants("pressure_mb").FirstOrDefault();

            string pictureUrl = (string)doc.Descendants("icon").FirstOrDefault();

            WebClient client = new WebClient();
            byte[] image = client.DownloadData("http:" + pictureUrl);
            MemoryStream stream = new MemoryStream(image);
            Bitmap icon = new Bitmap(stream);

            conditionPic.Image = icon;

            moonPhase.Text = moonPhs;
            maxTemp.Text = maxT;
            minTemp.Text = minT;
            humidity.Text = hum;
            windSpeed.Text = windSpd;
            atmPressure.Text = baroPrss;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void forecastBtn_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Datums", typeof(string));
            table.Columns.Add("Minimāla temperatūra", typeof(string));
            table.Columns.Add("Maksimāla temperatūra", typeof(string));
            table.Columns.Add("Spiediens", typeof(string));
            table.Columns.Add("Mēness fāze", typeof(string));
            table.Columns.Add("Laikapstākļi", typeof(Image));


            var cityName = forecastCity.Text;
            var requestUrl = $"http://api.weatherapi.com/v1/forecast.xml?key=ecdaff50705e449ab6311843250302&q={cityName}&days=5";

            XDocument doc = XDocument.Load(requestUrl);

            var forecastDays = doc.Descendants("forecastday");

            foreach (var day in forecastDays)
            {
                string pictureUrl = (string)day.Descendants("icon").FirstOrDefault();

                WebClient client = new WebClient();
                byte[] image = client.DownloadData("http:" + pictureUrl);
                MemoryStream stream = new MemoryStream(image);
                Bitmap icon = new Bitmap(stream);

                object[] row = new object[]
                {
                    (string)day.Descendants("date").FirstOrDefault(),
                    (string)day.Descendants("mintemp_c").FirstOrDefault(),
                    (string)day.Descendants("maxtemp_c").FirstOrDefault(),
                    (string)day.Descendants("pressure_mb").FirstOrDefault(),
                    (string)day.Descendants("moon_phase").FirstOrDefault(),
                    icon
                };
                table.Rows.Add(row);
            }

            forecast.DataSource = table;
        }

        private void saveCity_Click(object sender, EventArgs e)
        {
            var cityName = forecastCity.Text;
            TabPage page = new TabPage("Cat36");
            weatherTabs.TabPages.Add(page);
        }
    }
}
