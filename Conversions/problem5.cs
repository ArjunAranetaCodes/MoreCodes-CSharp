//Problem 5: Write a program that converts an array/list to string.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrNumbers = {"1", "2", "3"};
            string numbers = string.Join("",arrNumbers);

            Console.WriteLine(numbers);
            Console.ReadKey();
        }
    }
}
