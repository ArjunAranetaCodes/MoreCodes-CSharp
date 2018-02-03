//Problem 13: Write a program that outputs all even numbers in an array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3 , 4};

   foreach (int num in arrNumbers){
    if (num % 2 == 0){
     Console.WriteLine(num);
    }
   }
   Console.ReadKey();
  }
 }
}


