/*
Problem 17: Write a program to print the number pattern using loop.
1
12
123
1234
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

namespace Problem17
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
                    Console.Write(x + 1);
                }
                Console.WriteLine();
            }

            for (int y = row - 1; y > 0; y--)
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
