
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 4, 2, 3, -1 };
   int closest = 0;
   int numDiff = arrNumbers.Max();

   foreach (int num in arrNumbers){
    int diff = 0 - num;
    diff = Math.Abs(diff);
    if (diff < numDiff){
     numDiff = diff;
     closest = num;
    }
   }

   Console.WriteLine("Closest to zero is " +
    closest.ToString());
   Console.ReadKey();
  }
 }
}


