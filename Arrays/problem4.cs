//Problem 4: Write a program that outputs the first and last elements of an array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3 };

   Console.WriteLine(arrNumbers.First().ToString());
   Console.WriteLine(arrNumbers.Last().ToString());
   Console.ReadKey();
  }
 }
}


