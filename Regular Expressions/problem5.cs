//Problem 5: Write a program that matches time in 24 hour format.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "^(0?[1-9]|1[012])(:[0-5]\\d) [APap][mM]$";
            Console.WriteLine(Regex.IsMatch("25:00 am", pattern));
            Console.WriteLine(Regex.IsMatch("08:01 am", pattern));
            Console.ReadKey();
        }
    }
}
