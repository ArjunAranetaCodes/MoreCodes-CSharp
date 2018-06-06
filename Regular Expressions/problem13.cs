//Problem 13: Write a program that recognizes valid hex color value using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";
            Console.WriteLine(Regex.IsMatch("#fff", pattern));
            Console.WriteLine(Regex.IsMatch("#asdf", pattern));
            Console.ReadKey();
        }
    }
}
