//Problem 14: Write a program that recognizes valid hex color value using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([01]?\d\d?|2[0-4]\d|25[0-5])\.([01]?\d\d?|2[0-4]\d|25[0-5])\." +
                         @"([01]?\d\d?|2[0-4]\d|25[0-5])\.([01]?\d\d?|2[0-4]\d|25[0-5])$";
            Console.WriteLine(Regex.IsMatch("192.168.1.1", pattern));
            Console.WriteLine(Regex.IsMatch("1.1.1.1.1", pattern));
            Console.ReadKey();
        }
    }
}
