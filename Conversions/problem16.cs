//Problem 16: Write a program that converts feet to inch.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            int feet = 1;
            int inch = feet * 12;

            Console.WriteLine(inch);
            Console.ReadKey();
        }
    }
}
