using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RestSharp;


namespace weather

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Getdata(string location)
        {
            var client = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=%c+%t+%w+%h");
            var request = new RestRequest();
            request.AddParameter("method", "GET");

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                string[] weatherParameter = Regex.Split(response.Content, " ");

                Console.WriteLine("Weather: " + weatherParameter[0]);
                Console.WriteLine("Temp: " + weatherParameter[1]);
                Console.WriteLine("Wind: " + weatherParameter[2]);
                Console.WriteLine("Humidity: " + weatherParameter[3]);
                Console.WriteLine("Moon Phase: " + weatherParameter[4]);
            }

            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
