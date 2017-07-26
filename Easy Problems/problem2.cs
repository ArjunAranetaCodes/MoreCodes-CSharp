using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2{

 //Problem 2: Write a program that accepts two numbers
 //and perform all arithmetic operations.

 class Program{
  static void Main(string[] args){
   int num1 = 0;
   int num2 = 0;
   int sum = 0;
   int diff = 0;
   int prod = 0;
   int quot = 0;

   Console.Write("Enter value of num1: ");
   num1 = Int32.Parse(Console.ReadLine());
   Console.Write("Enter value of num2: ");
   num2 = Int32.Parse(Console.ReadLine());
   sum = num1 + num2;
   diff = num1 - num2;
   prod = num1 * num2;
   quot = num1 / num2;

   Console.WriteLine("Sum is " + sum.ToString());
   Console.WriteLine("Difference is " + diff.ToString());
   Console.WriteLine("Product is " + prod.ToString());
   Console.WriteLine("Quotient is " + quot.ToString());
   Console.ReadKey();
  }
 }
}
