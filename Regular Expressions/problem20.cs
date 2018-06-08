//Problem 20: Write a program that validates if string length is between 5 to 10 using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\w{5,10}\b";
            Console.WriteLine(Regex.IsMatch("Hello World", pattern));
            Console.WriteLine(Regex.IsMatch("Hi", pattern));
            Console.ReadKey();
        }
    }
}
