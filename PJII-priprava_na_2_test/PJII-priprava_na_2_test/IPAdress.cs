using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJII_priprava_na_2_test
{
    public class IPAdress
    {
        public string IP;
        public string Mask;
        public IPAdress(string ip, string mask)
        {
            this.IP = ip;
            this.Mask = mask;
        }
        public bool IsInNetwork(string ip)
        {
            string[] ipelements = ip.Split('.');
            string[] IPelements = IP.Split('.');
            string[] maskelements = Mask.Split('.');
            for (int i = 0; i < 4; i++)
            {
                if (maskelements[i] == "255")
                {
                    if (ipelements[i] != IPelements[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
