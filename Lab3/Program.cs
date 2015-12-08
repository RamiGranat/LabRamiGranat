using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.SetName("Solaire");
            Console.WriteLine(person1.GetName());

            Person person2 = new Person();
            person2.SetName("Lautrec");
            Console.WriteLine(person2.GetName());

            Person person3 = new Person();
            person3.SetName("Leeroy");
            Console.WriteLine(person3.GetName());

            Circle circle1 = new Circle();
            circle1.SetDiameter(5.5);
            Console.WriteLine(circle1.GetCircumference());

            Circle circle2 = new Circle();
            circle2.SetDiameter(9.1);
            Console.WriteLine(circle2.GetCircumference());

            Point point1 = new Point() { X = 32, Y = 1};

            Circle circle3 = new Circle();
            circle3.SetDiameter(4.7);
            circle3.SetCenter(point1);

        }
    }
}
