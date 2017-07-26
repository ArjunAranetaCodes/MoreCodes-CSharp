<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10{

 //Problem 10: Write a program that accepts three numbers
 //and outputs their average.

 class Program{
  static void Main(string[] args){
   int num1 = 0;
   int num2 = 0;
   int num3 = 0;
   int ave = 0;

   Console.Write("Enter value of num1: ");
   num1 = Int32.Parse(Console.ReadLine());
   Console.Write("Enter value of num2: ");
   num2 = Int32.Parse(Console.ReadLine());
   Console.Write("Enter value of num3: ");
   num3 = Int32.Parse(Console.ReadLine());
   ave = (num1 + num2 + num3) / 3;

   Console.WriteLine("Average is " + ave.ToString());
   Console.ReadKey();
  }
 }
}

</code></pre>
