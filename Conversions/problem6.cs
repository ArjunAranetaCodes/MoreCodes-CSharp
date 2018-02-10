//Problem 6: Write a program that converts a binary number to decimal number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.Write("Enter value of num: ");
            num = Int32.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            
            Console.ReadKey();
        }
    }
}
