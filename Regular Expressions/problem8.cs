//Problem 8: Write a program that checks if the String if valid url using Regular Expression.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(https?:\/\/)?(www\.)?([\w]+\.)+[‌​\w]{2,63}\/?$";
            Console.WriteLine(Regex.IsMatch("http://www.example.com", pattern));
            Console.WriteLine(Regex.IsMatch("wwwexamplecom", pattern));
            Console.ReadKey();
        }
    }
}
