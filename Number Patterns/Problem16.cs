/*
Problem 16: Write a program to print the number pattern using loop.
12345
1234
123
12
1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem16
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
                    Console.Write(x + 1);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
