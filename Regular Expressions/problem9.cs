//Problem 9: Write a program that checks if the string is alphanumeric using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(([A-Z].*[0-9])|([0-9].*[A-Z]))";
            Console.WriteLine(Regex.IsMatch("HelloWorld", pattern));
            Console.WriteLine(Regex.IsMatch("HelloWorld123", pattern));
            Console.ReadKey();
        }
    }
}
