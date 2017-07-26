<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15{

 //Problem 15: Write a program that will ask the user to
 //input n positive numbers. The program will terminate
 //if one of those number is not positive.

 class Program{
  static void Main(string[] args){
   int num = 0;
   while (num > -1){
    Console.Write("Enter a number: ");
    num = Int32.Parse(Console.ReadLine());
   }
   Console.Write("Terminated");
   Console.ReadKey();
  }
 }
}

</code></pre>
