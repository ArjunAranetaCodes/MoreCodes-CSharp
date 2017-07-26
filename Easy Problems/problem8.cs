<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8{

 //Problem 8: Write a program that outputs all numbers divisible by
 //5 from 1 to 30.

 class Program{
  static void Main(string[] args){
   int sum = 0;

   for (int x = 0; x <= 30; x++){
    if (x % 5 == 0){
     sum = sum + x;
    }
   }

   Console.WriteLine("The sum of 1 to 20 is " +
   sum.ToString());
   Console.ReadKey();
  }
 }
}

</code></pre>
