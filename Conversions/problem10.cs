//Problem 10: Write a program that converts a decimal number to octal number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = 256;
            string oct = "";

            while (dec > 0)
            {
                oct = (dec % 8).ToString() + oct;
                dec = dec / 8;
            }
            Console.WriteLine(oct);
            Console.ReadKey();
        }
    }
}
