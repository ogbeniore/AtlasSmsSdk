using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Sms.Sdk.Models
{
    public class Country
    {
        public string name { get; set; }
        public string mcc { get; set; }
        public string region_code { get; set; }
        public string country_code { get; set; }
    }

    public class Telco
    {
        public string name { get; set; }
        public int mnc { get; set; }
        public string services { get; set; }
        public string country_code { get; set; }
        public string mcc_mnc { get; set; }
    }

    public class Service
    {
        public string name { get; set; }
        public string action { get; set; }
        public string url { get; set; }
        public double price { get; set; }
        public string telco_id { get; set; }
        public string country_code { get; set; }
    }

    public class Error
    {
        public string message { get; set; }
    }
    public class Success
    {
        public string message { get; set; }
    }
    public class SendSmsErrorModel
    {
        public Country country { get; set; }
        public Telco telco { get; set; }
        public Service service { get; set; }
        public Error error { get; set; }
        public Success message { get; set; }
    }
}
