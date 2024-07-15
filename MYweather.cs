using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RestSharp;

namespace weather
{
    public partial class MYweather : Form
    {
        string CLocation;
        string Weather;
        string Temperature;
        string Wind;
        string Humidity;
        string Moonphase;
        string Precipitation;
        string Currenttime;
        string timezone;
        string Feels;
        string Moonday;
        string Sunrise;
        string Sunset;

        public MYweather()
        {
            InitializeComponent();
        }

        private void Getdata(string location)
        {
            var client = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=%c+%t+%w+%h+%m+%p+%l+%T+%Z+%f+%M+%S+%s");
            var request = new RestRequest();
            request.AddParameter("method", "GET");

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine("Response: " + response.Content); // Debugging: Print the raw response

                string[] weatherParameter = Regex.Split(response.Content, @"\s+");

                if (weatherParameter.Length >= 13)
                {
                    Weather = weatherParameter[0];
                    Temperature = weatherParameter[1];
                    Wind = weatherParameter[2];
                    Humidity = weatherParameter[3];
                    Moonphase = weatherParameter[4];
                    Precipitation = weatherParameter[5];
                    CLocation = weatherParameter[6];
                    Currenttime = weatherParameter[7];
                    timezone = weatherParameter[8];
                    Feels = weatherParameter[9];
                    Moonday = weatherParameter[10];
                    Sunrise = weatherParameter[11];
                    Sunset = weatherParameter[12];




                    DisplayData();
                }
                else
                {
                    MessageBox.Show("Error! Incomplete data received.");
                }
            }
            else
            {
                MessageBox.Show("Error! " + response.StatusCode);
            }
        }

        private void DisplayData()
        {
            selweather.Text = "WEATHER: " + Weather;
            seltemp.Text = "TEMPERATURE: " + Temperature;
            selwind.Text = "WIND: " + Wind;
            selhumidity.Text = "HUMIDITY: " + Humidity;
            selmoon.Text = "MOON PHASE: " + Moonphase;
            selper.Text = "PRECIPITATION: " + Precipitation;
            selloc.Text = "LOCATION: " + CLocation;
            seltime.Text = "TIME: " + Currenttime;
            selzone.Text = "TIME ZONE: " + timezone;
            selfeel.Text = "FEELS LIKE: " + Feels;
            selmoonday.Text = "MOONDAY: "+ Moonday;
            selsunrise.Text = "SUNRISE: " + Sunrise;
            selsunset.Text = "SUNSET: " + Sunset;
        }


        private void search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(location.Text))
            {
                try
                {
                    Getdata(location.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a location.");
            }
        }

        private void selmoon_Click(object sender, EventArgs e)
        {
            // Event handler logic...
        }

        private void selweather_Click(object sender, EventArgs e)
        {
            // Event handler logic...
        }

        private void MYweather_Load(object sender, EventArgs e)
        {

        }

        private void txtWeather_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
