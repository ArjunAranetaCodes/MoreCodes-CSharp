//Problem 7: Write a program that converts a decimal number to binary number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = 10;
            string binary = "";

            while (dec > 0)
            {
                binary = (dec % 2).ToString() + binary;
                dec = dec / 2;
            }
            Console.WriteLine(binary);
            Console.ReadKey();
        }
    }
}
