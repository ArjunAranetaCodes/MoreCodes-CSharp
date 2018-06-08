//Problem 17: Write a program that removes the last word in a string using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello World";
            string pattern = @"\w+$";
            Console.WriteLine(Regex.Replace(word, pattern, ""));
            Console.ReadKey();
        }
    }
}
