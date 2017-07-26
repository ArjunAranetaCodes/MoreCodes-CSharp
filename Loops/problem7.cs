<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7{

 //Problem 7: Write a program that outputs the sum of
 //numbers from 1 to n.

 class Program{
  static void Main(string[] args){
   int n = 10;
   int sum = 0;
   for (int x = 0; x <= n; x++){
    sum = sum + x;
   }
   Console.WriteLine("Sum is " + sum.ToString());
   Console.ReadKey();
  }
 }
}

</code></pre>
