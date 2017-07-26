<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2{

 //Problem 2: Write a program that outputs 5 random integers.

 class Program{
  static void Main(string[] args){
   Random rand = new Random();
   for (int x = 0; x < 5; x++){
    Console.WriteLine(rand.Next(1, 9));
   }
   Console.ReadKey();
  }
 }
}

</code></pre>
