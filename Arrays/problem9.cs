//Problem 9: Write a program that outputs the sum of an array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3 };
   Console.WriteLine("Sum is " + arrNumbers.Sum());
   Console.ReadKey();
  }
 }
}


