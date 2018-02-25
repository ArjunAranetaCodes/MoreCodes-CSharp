using System;
//Problem 19: Write a program that converts numbers to words.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = "program";
            String letter = "a";

            if (word.Contains(letter))
            {
                Console.WriteLine("Contains a");
            }
            else
            {
                Console.WriteLine("Does not contain a");
            }
            Console.ReadKey();
        }
    }
}
