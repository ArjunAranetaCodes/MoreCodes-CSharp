//Problem 11: Write a program that converts numbers of day to minutes.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 1;
            int minutes = day * 24 * 60;

            Console.WriteLine(minutes);
            Console.ReadKey();
        }
    }
}
