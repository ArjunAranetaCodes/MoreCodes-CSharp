//Problem 16: Write a program that takes a value inside a <a> tag using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "<a>Hello World</a>";
            string pattern = @"<([^""]*""|'[^']*'|[^'"">])*>";
            Console.WriteLine(Regex.Replace(word, pattern, ""));
            Console.ReadKey();
        }
    }
}
