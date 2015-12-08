using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4;

namespace ArvAbstractIsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            //object obj = 21;
            //string str ="Hello";
            //int i = 1337;
            //double dou = 1.21;
            //char cha = 'a';
            //bool boo = false;

            //str = (string)obj;
            //i = (int)dou;
            //cha = (char)dou;
            //boo = (bool)obj;
            //obj = dou;

            //Point3D point = new Point3D(10, 31, 7) { X = 10, Y = 31, Z = 5};
            //C c = new C();
            SUV suv = new SUV();
            Bil bil = suv;
            SUV suv2 = (SUV)bil;

            bil.Drive();
            suv.Drive();
            //Console.WriteLine(c);
        }
    }
}
