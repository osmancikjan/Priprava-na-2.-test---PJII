using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJII_priprava_na_2_test
{
    public class FirewallException : Exception
    {
        public IPAdress IP { get; set; }
        public FirewallException(string ip)
        {
            IP.IP = ip;
        }
    }
}
