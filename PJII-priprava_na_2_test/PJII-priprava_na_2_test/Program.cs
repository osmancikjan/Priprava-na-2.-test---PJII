using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJII_priprava_na_2_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Firewall fw = new Firewall("rules.txt");
            Console.WriteLine(fw.Test("192.168.10.100"));
            Console.WriteLine(fw.Test("192.168.11.100"));
            Console.WriteLine(fw.Test("192.168.11.100"));
            fw.Info();
            Console.ReadLine();
        }
    }
}
