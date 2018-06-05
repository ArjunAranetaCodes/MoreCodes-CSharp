//Problem 10: Write a program that prints an integer with commas separator using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "1000";
            string pattern = @"(\d)(?=(\d{3})+$)";
            Console.WriteLine(Regex.Replace(word, pattern, "$1,"));
            Console.ReadKey();
        }
    }
}
