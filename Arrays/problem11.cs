//Problem 11: Write a program that reverses an array/list of integer values.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3 };
   Array.Reverse(arrNumbers);

   foreach (int num in arrNumbers){
    Console.WriteLine(num.ToString());
   }
   Console.ReadKey();
  }
 }
}


