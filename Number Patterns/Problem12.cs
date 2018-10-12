/*
Problem 12: Write a program to print the pattern of asterisks using loop.
*****
****
***
**
*
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            for (int y = row; y > 0; y--)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
