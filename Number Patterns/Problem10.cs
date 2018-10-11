/*
Problem 10: Write a program to print the number pattern using loop.
12345
23456
34567
45678
56789
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            int col = 5;
            int min = 1;
            for (int y = 0; y < row; y++)
            {
                int num = min + y;
                for (int x = 0; x < col; x++)
                {
                    Console.Write(num);
                    num = num + 1;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
