using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJII_priprava_na_2_test
{
    public class Rule
    {
        public IPAdress Network { get; set; }
        public Access Type { get; set; }
        public int Tested { get; set; }

        public Rule(IPAdress network, Access type)
        {
            Network = network;
            Type = type;
            Tested = 0;
        }
        public override string ToString()
        {
            return "IP: " + Network.IP + ", " + Network.Mask + " bylo uspesne" + Tested.ToString() + " krat.";
        }
    }
}
