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
        }
    }
}
