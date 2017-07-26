using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6{

 //Problem 6: Write a program that outputs all odd numbers
 //below 20.

 class Program{
  static void Main(string[] args){
   for (int x = 0; x <= 20; x++){
    if (x % 2 == 1){
     Console.WriteLine(x);
    }
   }
   Console.ReadKey();
  }
 }
}
