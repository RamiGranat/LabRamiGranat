using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            float floater = 1.21f;
            long longa = 20l;
            char charred = 'a';
            string unidentifiedFlyingString = "Hej";
            ulong leiUlong = 1337UL;

            int heltal = 7;
            int heltal2 = 13;

            Console.WriteLine(heltal ^ heltal2);
            Console.WriteLine(heltal & heltal2);
            Console.WriteLine(heltal | heltal2);
            Console.WriteLine(heltal >> heltal2);
            Console.WriteLine(heltal << heltal2);

            Point point = new Point(11, 22);
            Point3D point3D = (Point3D)point;
            Console.WriteLine(point3D);

            MyDoubleType mdt1 = new MyDoubleType(5);

            MyDoubleType mdt2 = mdt1 + 5;

            MyDoubleType mdt3 = mdt1 + mdt2;

            MyDoubleType mdt4 = new MyDoubleType(5);
            var tre = new MyDoubleType(0);
            //var hej = tre/tre;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",

                 mdt1, mdt2, mdt3, mdt1 > mdt2, mdt1 == mdt4);

            Console.ReadLine();
        }
    }
}
