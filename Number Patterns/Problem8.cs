/*
Problem 8: Write a program to print the number pattern of ones and zeros using loop.
11111
11111
11011
11111
11111
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            int col = 5;
            for (int y = 0; y < row; y++)
            {
                for (int x = 0; x < col; x++)
                {
                    if (x == (row / 2) && y == (col / 2))
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
