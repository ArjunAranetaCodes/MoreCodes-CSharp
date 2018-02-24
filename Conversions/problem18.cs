//Problem 18: Write a program that converts liter to milliliter.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem18
{
    class Program
    {
        static void Main(string[] args)
        {
            int liter = 1;
            int milliliter = liter* 1000;

            Console.WriteLine(milliliter);
            Console.ReadKey();
        }
    }
}
