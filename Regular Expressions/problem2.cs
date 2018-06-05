//Problem 2: Write a program that matches email address.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "^[_A-Za-z0-9-+]+(.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(.[A-Za-z0-9]+)*(.[A-Za-z]{2,})$";
            Console.WriteLine(Regex.IsMatch("mark@yahoo.com", pattern));
            Console.WriteLine(Regex.IsMatch("mark-yahoo.com", pattern));
            Console.ReadKey();
        }
    }
}
