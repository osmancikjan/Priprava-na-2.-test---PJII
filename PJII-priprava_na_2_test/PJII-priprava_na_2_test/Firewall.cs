using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJII_priprava_na_2_test
{
    class Firewall
    {
        public IList<Rule> Rules = new List<Rule>();
        public Firewall(string File)
        {
            using (FileStream file = new FileStream(File, FileMode.Open))
            {
                using (StreamReader sourceFile = new StreamReader(file))
                {
                    string line;
                    while ((line = sourceFile.ReadLine()) != null)
                    {
                        line = line.Replace(" ", "");
                        string[] a = line.Split('-');
                        Rule r = new Rule(new IPAdress(a[0], a[1]), (a[2].Equals("A") ? Access.Allow : Access.Deny));
                        //Console.WriteLine(r.Network.IP + " " + r.Network.mask + " " + r.Type.ToString());
                        this.Rules.Add(r);
                    }

                }
            }
        }
        public bool Test(string ip)
        {
            int trueVal = 0;
            int falseVal = 0;
            int n = Rules.Count;
            for (int i = 0; i< Rules.Count; i++)
            {
                Rule r = Rules[i];
                if (r.Network.IsInNetwork(ip))
                {
                    trueVal += n;
                    Rules[i].Tested += 1;
                }
                else
                {
                    falseVal += n;
                }
                n--;
            }
            if(trueVal == falseVal)
            {
                throw new FirewallException(ip);
            }
            if (trueVal > falseVal)
            {
                return true;
            }
            return false;
        }
        public void Info()
        {
            foreach(Rule r in Rules)
            {
                Console.WriteLine(r.ToString());
            }
        }
    }
}
