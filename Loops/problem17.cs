using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17{

 //Problem 17: Write a program that outputs the
 //fibonacci sequence of a number.

 class Program{
  static void Main(string[] args){
   int num1 = 1;
   int num2 = 1;

   Console.WriteLine(num1);
   while (num2 < 100){
    Console.WriteLine(num2);
    num2 = num2 + num1;
    num1 = num2 - num1;
   }
   Console.ReadKey();
  }
 }
}
