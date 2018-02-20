//Problem 15: Write a program that converts letters to ASCII.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {            
          string letter = "x"; //120
          byte[] ascii = Encoding.ASCII.GetBytes(letter);

          Console.WriteLine(ascii[0]);
          Console.ReadKey();
        }
    }
}
