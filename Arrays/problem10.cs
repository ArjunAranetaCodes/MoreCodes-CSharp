//Problem 10: Write a program that outputs the average of an array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3 };
   Console.WriteLine("Average is " + arrNumbers.Average());
   Console.ReadKey();
  }
 }
}


