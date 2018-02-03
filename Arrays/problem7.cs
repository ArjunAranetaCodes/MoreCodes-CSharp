//Problem 7: Write a program that finds the largest number in an array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3 };
   Console.WriteLine("Largest Number: " + arrNumbers.Max());
   Console.ReadKey();
  }
 }
}


