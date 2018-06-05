//Problem 7: Write a program that counts vowels in a String using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello World";
            string pattern = "[^aeiouAEIOU]";
            int count = Regex.Replace(word, pattern, "").Count();
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
