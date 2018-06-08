//Problem 18: Write a program that extracts string inside quotation marks using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem18
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello 'World'";
            string pattern = @"'([^""]*)'";
            string extract = Regex.Matches(word, pattern)[0].ToString();
            Console.WriteLine(extract);
            Console.ReadKey();
        }
    }
}
