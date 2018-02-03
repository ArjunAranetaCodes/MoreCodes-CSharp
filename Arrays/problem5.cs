//Problem 5: Write a program that outputs array/list using loops.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3 };

   foreach (int num in arrNumbers){
    Console.WriteLine(num.ToString());
   }
   Console.ReadKey();
  }
 }
}


