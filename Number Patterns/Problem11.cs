/*
Problem 11: Write a program to print the pattern of asterisks using loop.
*
**
***
****
*****
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            for (int y = 0; y <= row; y++)
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
