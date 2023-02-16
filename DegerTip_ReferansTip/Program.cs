using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DegerTip_ReferansTip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deger Tip

            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2); // CVP: 10

            // Referans Tip

            string[] sehirler1 = new string[] { "AYDIN ", "İSTANBUL " };
            string[] sehirler2 = new string[] { "KAYSERİ ", "MUŞ " };
            sehirler2 = sehirler1;
            sehirler1[0] = "ADANA";
            Console.WriteLine(sehirler2[0]);
            Console.WriteLine(sehirler2[1]);


            Console.ReadLine();
        }
    }
}
