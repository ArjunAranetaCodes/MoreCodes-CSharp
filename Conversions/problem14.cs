//Problem 14: Write a program that converts lower case to upper case characters.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abc";
            str = str.ToUpper();

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
