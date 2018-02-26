//Problem 20: Write a program that converts a number to its 
//corresponding month (e.g. 1 = January).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = "anna";
            char[] temp = word.ToCharArray();
            Array.Reverse(temp);
            String tempWord = new string(temp);

            if (word == tempWord)
            {
                Console.Write("Palindrome");
            }
            else
            {
                Console.Write("Not Palindrome");
            }
            
            Console.ReadKey();
        }
    }
}
