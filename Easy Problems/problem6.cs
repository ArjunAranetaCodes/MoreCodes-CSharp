using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6{

 //Problem 6: Write a program that checks a number
 //input is even or odd.

 class Program{
  static void Main(string[] args){
   int num = 0;

   Console.Write("Enter value of num: ");
   num = Int32.Parse(Console.ReadLine());

   if (num % 2 == 0){
   Console.WriteLine("Number is even");
   }
   else{
   Console.WriteLine("Number is odd");
   }

   Console.ReadKey();
  }
 }
}
