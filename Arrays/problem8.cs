//Problem 8: Write a program that finds the lowest number in an array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3 };
   Console.WriteLine("Lowest Number: " + arrNumbers.Min());
   Console.ReadKey();
  }
 }
}


