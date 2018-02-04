//Problem 4: Write a program that converts a string to array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "1,2,3";
            string[] arrNumbers = numbers.Split(',');
            foreach (string num in arrNumbers){
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
