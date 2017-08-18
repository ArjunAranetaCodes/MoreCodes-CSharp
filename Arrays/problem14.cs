
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3, 4 };

   foreach (int num in arrNumbers){
    if (num % 2 == 1){
     Console.WriteLine(num);
    }
   }
   Console.ReadKey();
  }
 }
}


