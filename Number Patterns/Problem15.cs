/*
Problem 15: Write a program to print the number pattern using loop.
11111
2222
333
44
5
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            int num = 1;
            for (int y = row; y > 0; y--)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write(num);
                }
                num = num + 1;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
