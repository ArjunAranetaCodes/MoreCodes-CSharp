<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4{

 //Problem 4: Write a program that outputs an asterisk
 //pyramid.

 class Program{
  static void Main(string[] args){
   for (int y = 0; y <= 5; y++){
    for (int x = 0; x <= y; x++){
     Console.Write("*");
    }
    Console.WriteLine();
   }
   Console.ReadKey();
  }
 }
}

</code></pre>
