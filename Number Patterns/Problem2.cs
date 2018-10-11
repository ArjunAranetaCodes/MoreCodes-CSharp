/*
Problem 2: Write a program to print the number pattern of ones and zeros using loop.
11111
00000
11111
00000
11111
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (y % 2 == 0)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
