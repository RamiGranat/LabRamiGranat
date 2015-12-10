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
            ulong longer = 1337UL;

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

            Console.ReadLine();
        }
    }
}
