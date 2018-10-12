/*
Problem 14: Write a program to print the number pattern using loop.
1
22
333
4444
55555
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem14
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
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
