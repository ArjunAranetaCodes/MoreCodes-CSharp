//Problem 12: Write a program that converts numbers of day to seconds.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 1;
            int seconds = day * 24 * 60 * 60;

            Console.WriteLine(seconds);
            Console.ReadKey();
        }
    }
}
