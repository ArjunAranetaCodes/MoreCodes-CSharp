using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20{

 //Problem 20: (RecursioN) Write a program that outputs the
 //sum of numbers from 1 to n.

 class Program{
  static void Main(string[] args){
   Console.WriteLine("Sum is " + GetSum(10, 0));
   Console.ReadKey();
  }

  static int GetSum(int num, int sum){
   if (num == 0){
    return sum;
   }else{
    return GetSum((num - 1), (sum + num));
   }
  }
 }
}
