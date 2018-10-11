/*
Problem 3: Write a program to print the number pattern of ones and zeros using loop.
01010
01010
01010
01010
01010
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (x % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
