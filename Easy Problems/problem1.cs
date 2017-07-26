<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1{

 //Problem 1: Write a program that accepts
 //two numbers and find the sum.

 class Program{
  static void Main(string[] args){
   int num1 = 0;
   int num2 = 0;
   int sum = 0;

   Console.Write("Enter value of num1: ");
   num1 = Int32.Parse(Console.ReadLine());
   Console.Write("Enter value of num2: ");
   num2 = Int32.Parse(Console.ReadLine());
   sum = num1 + num2;

   Console.WriteLine("Sum is " + sum.ToString());
   Console.ReadKey();
  }
 }
}

</code></pre>
