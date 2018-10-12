/*
Problem 19: Write a program to print the number pattern using loop.
11 11
11 11
   
11 11
11 11
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem19
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
                    if (col / 2 == x || row / 2 == y)
                    {
                        Console.Write(" ");
                    }
                    else if ((col % 2 == 0 && (col / 2) == x) || (row % 2 == 0 && (row / 2) == y))
                    {
                        Console.Write(" ");
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
