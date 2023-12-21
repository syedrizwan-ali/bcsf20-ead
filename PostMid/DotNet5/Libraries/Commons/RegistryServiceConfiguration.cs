using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class RegistryServiceConfiguration
    {
        public static string ConfigSection { get { return "RegistryServiceConfiguration"; } }
        public string Url { get; set; }
    }
}
