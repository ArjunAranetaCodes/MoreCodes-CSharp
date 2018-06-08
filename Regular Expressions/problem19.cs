//Problem 19: Write a program that counts all numbers in a string using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem19
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello World123";
            string pattern = @"[^0-9]";
            int count = Regex.Replace(word, pattern, "").Count();
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
