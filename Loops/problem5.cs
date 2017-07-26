using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5{

 //Problem 5: Write a program that outputs all even
 //numbers below 20.

 class Program{
  static void Main(string[] args){
   for (int x = 0; x <= 20; x++){
    if (x % 2 == 0){
     Console.WriteLine(x);
    }
   }
   Console.ReadKey();
  }
 }
}
