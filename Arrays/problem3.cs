
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 1, 2, 3 };
   int count = 0;

   foreach (int num in arrNumbers){
    if (num == 1){
     count = count + 1;
    }
   }

   Console.WriteLine("Occurence: " + count.ToString());
   Console.ReadKey();
  }
 }
}


