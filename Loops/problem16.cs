<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16{

 //Problem 16: Write a program that outputs the factorial
 //of a number.

 class Program{
  static void Main(string[] args){
   int num = 5;
   int fact = 1;

   for (int x = num; x >= 1; x--){
    fact = fact * x;
   }
   Console.WriteLine("Factorial of 5 is " + fact.ToString());
   Console.ReadKey();
  }
 }
}

</code></pre>
