/*
Problem 20: Write a program to print the number pattern using loop.
  1
 222
33333
 444
  5
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            int x = 0;
            int rows = 3;
            int stars = 1;
            int blank = rows - 1;

            for (y = 1; y < rows * 2; y++)
            {
                for (x = 1; x <= blank; x++)
                {
                    Console.Write(" ");
                }

                for (x = 1; x < stars * 2; x++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                if (y < rows)
                {
                    blank--;
                    stars++;
                }
                else
                {
                    blank++;
                    stars--;
                }
            }
            Console.ReadKey();
        }
    }
}
