using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7{

 //Problem 7: Write a program that finds the sum of all
 //numbers from 1 to 20.

 class Program{
  static void Main(string[] args){
   int sum = 0;

   for (int x = 0; x <= 20; x++){
    sum = sum + x;
   }

   Console.WriteLine("The sum of 1 to 20 is " +
    sum.ToString());
   Console.ReadKey();
  }
 }
}
