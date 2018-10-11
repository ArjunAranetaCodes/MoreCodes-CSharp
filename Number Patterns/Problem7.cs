/*
Problem 7: Write a program to print the number pattern of ones and zeros using loop.
10101
01010
10101
01010
10101
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    count += 1;
                    if (count % 2 == 1)
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
