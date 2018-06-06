//Problem 15: Write a program that takes a value inside a <div> tag using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "<div>Hello World</div>";
            string pattern = @"<([^""]*""|'[^']*'|[^'"">])*>";
            Console.WriteLine(Regex.Replace(word, pattern, ""));
            Console.ReadKey();
        }
    }
}
