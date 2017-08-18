
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6{
 class Program{
  static void Main(string[] args){
   int[] arrNumbers = { 1, 2, 3 };

   if (arrNumbers.Contains(2)){
    Console.WriteLine("Contains 2");
   }else{
    Console.WriteLine("Does not contain 2");
   }
   Console.ReadKey();
  }
 }
}


