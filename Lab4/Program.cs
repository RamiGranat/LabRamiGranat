using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bed bed = new Bed();
            Bed bed2 = new Bed(3, true);
            Book book = new Book();
            Book book2 = new Book("Lords of Mars", 416);
            Cykel cykel = new Cykel("BMW", 13, "tvahjuling");
            Console.WriteLine("Write the gear of your bike.");
            cykel.ChangeGears(int.Parse(Console.ReadLine()));
            Bil bil = new Bil();
            Bil bil2 = new Bil("volvo", 4, "silver", "suv");
            Radio radio = new Radio() {Volume=50, On=false, Frequency=240 };
            Radio radio2 = new Radio() { Volume = 99, On = true, Frequency = 120 };
            Radio radio3 = new Radio() { Volume = 29, On = false, Frequency = 40 };
            Console.WriteLine(bil);
            Console.WriteLine(bil2);
            Console.WriteLine(radio);
            Console.WriteLine(radio2);
            Console.WriteLine(radio3);
            Console.WriteLine(cykel);
            Console.WriteLine(book);
            Console.WriteLine(book2);
            Console.WriteLine(bed);
            Console.WriteLine(bed2);
        }
    }
}
