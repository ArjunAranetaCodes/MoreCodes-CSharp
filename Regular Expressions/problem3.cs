//Problem 3: Write a program that checks if string contains sample format date of (yyyy-mm-dd)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "([0-9]{4})-([0-9]{2})-([0-9]{2})";
            Console.WriteLine(Regex.IsMatch("2018-01-02", pattern));
            Console.WriteLine(Regex.IsMatch("01-01-02", pattern));
            Console.ReadKey();
        }
    }
}
