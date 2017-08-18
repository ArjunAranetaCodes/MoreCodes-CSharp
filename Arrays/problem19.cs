
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19{
 class Program{
  static void Main(string[] args){
   int[] array1 = { 1, 2, 3 };
   int[] array2 = { 1, 2, 3 };
   int arr1Length = array1.Length;
   int arr2Length = array2.Length;

   Array.Resize(ref array1, arr1Length + arr2Length);

   int y = 0;
   for (int x = arr1Length; x < array1.Length; x++){
    array1[x] = array2[y];
    y++;
   }

   foreach (int num in array1){
   Console.WriteLine(num);
   }

   Console.ReadKey();
  }
 }
}


