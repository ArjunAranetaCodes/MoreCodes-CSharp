using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9{

 //Problem 9: Write a program that accepts a number
 //and outputs 1 to the input (1 to n).

 class Program{
  static void Main(string[] args){
   int num = 0;
   int sum = 0;

   Console.Write("Enter value of num: ");
   num = Int32.Parse(Console.ReadLine());

   for (int x = 0; x <= num; x++){
    sum = sum + x;
   }

   Console.WriteLine("The sum of 1 to " + num.ToString() +
    " is " + sum.ToString());
   Console.ReadKey();
  }
 }
}
