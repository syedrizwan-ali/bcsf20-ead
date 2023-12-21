using System;

namespace Commons
{
    public class ServiceConfiguration
    {
        public static string ConfigSection { get { return "ServiceConfiguration"; } }
        public string Url { get; set; }
    }
}
