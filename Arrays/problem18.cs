
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem18{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 3, 2 ,4};
   Array.Sort(arrNumbers);
   Array.Reverse(arrNumbers);

   foreach (int num in arrNumbers){
    Console.WriteLine(num.ToString());
   }
   Console.ReadKey();
  }
 }
}


