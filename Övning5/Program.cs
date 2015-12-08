using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            uppgift 4
            Console.WriteLine("Skriv ett nummer");
            Console.WriteLine(number(int.Parse(Console.ReadLine())));
            */

            /*
            uppgift 5
            int[] myArray = { 4, 3, 6, 7, 8, 5 };
            antalParametrar(myArray);
            */

            //uppgift 6
            int myInt = 1;
            myRecursive(ref myInt);

            //    int myInt = 5;
            //    int operand1 = 5;
            //    int operand2 = 10;
            //    int result;

            //    add(ref myInt);
            //    Console.WriteLine(myInt);

            //    add(operand1, operand2, out result);
            //    Console.WriteLine(result);

            //    multiply(operand1, operand2, out result);
            //    Console.WriteLine(result);

            //    Console.ReadLine();
            //    //int myOtherInt = 5;
            //    //multiply(ref myOtherInt);
            //    //Console.WriteLine(myOtherInt);
            //    //Console.ReadLine();
            //}
            //static void add(ref int myInt)
            //{
            //    myInt += 10;
            //}
            //static void multiply(ref int myInt)
            //{
            //     myInt *= 10;
            //}
            //static void add(int operand1, int operand2, out int myInt)
            //{
            //    myInt = operand1 + operand2;
            //}
            //static void multiply(int operand1, int operand2, out int myInt)
            //{
            //    myInt = operand1 * operand2;
        }
        //uppgift 4
        static string number(int tal)
        {
            if (tal > 0)
            {
                return ("Talet är positivt");
            }
            else if (tal < 0)
            {
                return ("Talet är negativt");
            }
            else 
            {
                return ("Talet är noll");
            }
        }
        //uppgift 5
        static void antalParametrar(int[] myArray)
        {
            foreach (int item in myArray)
            {
                Console.WriteLine(item);
            }
        }
        static void myRecursive(ref int myInt)
        {
            Console.WriteLine(myInt);
            myInt++;
            if (myInt <= 10)
            {
                myRecursive(ref myInt);
            }
        }
    }
}
