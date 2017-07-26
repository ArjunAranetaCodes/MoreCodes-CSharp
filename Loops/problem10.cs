using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10{

 //Problem 10: Write a program to check whether a given
 //number is an armstrong number or not.

 class Program{
  static void Main(string[] args){
   int num = 371;
   int sum = 0;
   int temp = 0;
   int rmdr = 0;

   temp = num;

   while (temp != 0){
    rmdr = temp % 10;
    sum = sum + (rmdr * rmdr * rmdr);
    temp = temp / 10;
   }

   if (num == sum){
    Console.WriteLine("Armstrong number");
   }else {
    Console.WriteLine("Not an Armstrong number");
   }
   Console.ReadKey();
  }
 }
}
