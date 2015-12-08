using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double DowJones = 4.6;
            double Nasdaq = 4.1;
            double Stockholm = -2.4;
            double Milano = -6.7;
            double Paris = -5.5;
            string name1 = "Dow Jones";
            string name2 = "Nasdaq";
            string name3 = "Stockholm";
            string name4 = "Milano";
            string name5 = "Paris";

            const double PI = Math.PI;
            const double roundedPI = Math.PI;
            const double veryRoundedPI = Math.PI;


            string namn = "Jonas";
            string stad = "Helsingborg";
            string stadsdel = "Stattena";
            string affär = "Hemköp";

            DowJones = 3.2;
            Nasdaq = 5.1;
            Stockholm = 9.2;
            Milano = -78532.1;
            Paris = -75.2;
            name1 = "Jow Dones";
            name2 = " Dasnaq";
            name3 = "Hockstolm";
            name4 = "Limano";
            name5 = "Rapis";

            //PI = 1337;
            //roundedPI = 2000;
            //veryRoundedPI = 1.21;
            //You can't change the PI man!!

            namn = "Rami";
            stad = "Helsingborg";
            stadsdel = "Dalhem";
            affär = "ICA Nära Kometen";

            Console.WriteLine("{0}  sjönk med {1} procent och {2} med {3} procent. {4} {5} procent, {6} {7} procent, {8} {9} procent.", name1, DowJones, name2, Nasdaq, name3, Stockholm, name4, Milano, name5, Paris);
            Console.WriteLine("Talet PI är cirka {0:F9} men kan avrundas till {1:F2} och kan lite grovt skrivas som {2:F0}.", PI, roundedPI, veryRoundedPI);
            Console.WriteLine("Han heter {0} och bor i {1} på {2} vid {3}.", namn, stad, stadsdel, affär);
        }
    }
}
