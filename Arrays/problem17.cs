//Problem 17: Write a program that inserts an element in an array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3 };

   foreach (int num in arrNumbers){
    Console.WriteLine(num.ToString());
   }

   Array.Resize(ref arrNumbers, arrNumbers.Length + 1);
   arrNumbers[3] = 5;

   Console.WriteLine("New Array");

   foreach (int num in arrNumbers){
    Console.WriteLine(num.ToString());
   }


   Console.ReadKey();
  }
 }
}


