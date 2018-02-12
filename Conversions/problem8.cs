//Problem 8: Write a program that converts a decimal number to hexadecimal number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = 256;
            string hex = "";

            while (dec > 0)
            {
                hex = (dec % 16).ToString() + hex;
                dec = dec / 16;
            }
            Console.WriteLine(hex);
            Console.ReadKey();

        }
    }
}
