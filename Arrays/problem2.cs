//Problem 2: Write a program that gets the index of an element in an array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2{
 class Program{
  static void Main(string[] args){
   int[] arrNumers = { 1, 2, 3 };

   Console.Write(Array.IndexOf(arrNumers, 2));
   Console.ReadKey();
  }
 }
}


