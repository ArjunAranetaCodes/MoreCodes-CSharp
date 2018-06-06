//Problem 11: Write a program that counts the occurrence of a string in a string using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "HelloWorldHelloWorld";
            string pattern = @"Hello";
            int count = Regex.Matches(word, pattern).Count;
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
