using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19{

 //Problem 19: (Recursion) Write a program that outputs
 //all even numbers below 20.

 class Program{
  static void Main(string[] args){
   PrintEven(10);
   Console.ReadKey();
  }

  static int PrintEven(int num){
   if (num == 0){
    return num;
   }else{
    if (num % 2 == 0){
     Console.WriteLine(num);
    }
    return PrintEven(num - 1);
   }
  }
 }
}
