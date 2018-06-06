//Problem 12: Write a program that counts the occurrence of digits in a string using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello12 World12";
            string pattern = @"\D";
            Console.WriteLine(Regex.Replace(word, pattern, "").Count());
            Console.ReadKey();
        }
    }
}
