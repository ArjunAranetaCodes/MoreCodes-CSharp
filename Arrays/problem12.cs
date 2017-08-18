
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12{
 class Program{
  static void Main(string[] args){
   int[] array1 = { 1, 2, 3};
   int[] array2 = { 1, 2, 3};

   if (array1.SequenceEqual(array2)){
    Console.WriteLine("Equal Arrays");
   }else{
    Console.WriteLine("Not Equal");
   }

   Console.ReadKey();
  }
 }
}


