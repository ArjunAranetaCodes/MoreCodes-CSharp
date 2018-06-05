//Problem 6: Write a program that removes white space and non-visible characters.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello World";
            string pattern = "\\s";
            Console.WriteLine(Regex.Replace(word, pattern, ""));
            Console.ReadKey();
        }
    }
}
