﻿using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RestSharp;

namespace weather
{
    public partial class Form1 : Form
    {
        string Weather;
        string Temperature;
        string Wind;
        string Humidity;
        string Moonphase;
        string Precipitation;
        string CLocation;
        string Currenttime;
        string timezone;
        string Feels;

        public Form1()
        {
            InitializeComponent();
        }

        private void Getdata(string location)
        {
            var client = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=%C+%t+%w+%h+%m+%p+%l+%T+%Z+%f");

            var request = new RestRequest();
            request.AddParameter("method", "GET");

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                // Use regular expressions to handle multiple spaces more robustly
                string[] weatherParameter = Regex.Split(response.Content, @"\s+");

                if (weatherParameter.Length >= 10)
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
            selmoon.Text = "Moon Phase: " + Moonphase;
            selper.Text = "PRECIPITATION: " + Precipitation;
            selloc.Text = "Location: " + CLocation;
            seltime.Text = "TIME: " + Currenttime;
            selzone.Text = "TIME ZONE: " + timezone;
            selfeel.Text = "FEELS LIKE: " + Feels;
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

        }
    }
}
