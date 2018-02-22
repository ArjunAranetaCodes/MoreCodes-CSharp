//Problem 17: Write a program that converts kilometer to meter.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometer = 1;
            int meter = kilometer * 1000;

            Console.WriteLine(meter);
            Console.ReadKey();
        }
    }
}
