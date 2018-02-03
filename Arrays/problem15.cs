//Problem 15: Write a program that copies values of an array/list to another array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15{
 class Program{
  static void Main(string[] args){
   int[] array1 = { 1, 2, 3 };
   int[] array2;

   array2 = array1;

   foreach (int num in array2){
    Console.WriteLine(num.ToString());
   }
   Console.ReadKey();
  }
 }
}


