//Problem 4: Write a program that matches time in 12 hour format.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(((0[1-9])|(1[0-2])):([0-5])([0-9])\\s(a|p)m)";
            Console.WriteLine(Regex.IsMatch("08:00 am", pattern));
            Console.WriteLine(Regex.IsMatch("18:00 pm", pattern));
            Console.ReadKey();
        }
    }
}
