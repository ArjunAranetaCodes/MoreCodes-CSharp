//Problem 1: Write a program to test if the first character of the String is uppercase.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
        string pattern = "^[A-Z][a-z0-9_-]{3,19}$";
        Console.WriteLine(Regex.IsMatch("Hello", pattern));
        Console.WriteLine(Regex.IsMatch("world", pattern));
        Console.ReadKey();
        }
    }
}
