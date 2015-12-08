using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRamiGranat
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, counter = 10;
            Console.WriteLine("Skriv ett tal.");
            int tal = int.Parse(Console.ReadLine());
            min = tal;
            counter--;
            while (counter > 0)
            {
                Console.WriteLine("Skrive ett tal.");
                tal = int.Parse(Console.ReadLine());
                if (tal < counter)
                    min = tal;
                    counter--;
                {
            Console.WriteLine(min);
                
                }
            }
        }
    }
}
