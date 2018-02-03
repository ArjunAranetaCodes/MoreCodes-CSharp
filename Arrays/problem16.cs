//Problem 16: Write a program that deletes an element in an array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3, 4 };
   int n = 2;
   int indexOfNum = Array.IndexOf(arrNumbers, n);

   for (int x = 0; x < arrNumbers.Length; x++){
    if ((x >= indexOfNum) && (x < arrNumbers.Length - 1)){
     arrNumbers[x] = arrNumbers[x + 1];
    }
   }
   Array.Resize(ref arrNumbers, arrNumbers.Length - 1);

   foreach (int num in arrNumbers){
    Console.WriteLine(num.ToString());
   }
   Console.ReadKey();
  }
 }
}


