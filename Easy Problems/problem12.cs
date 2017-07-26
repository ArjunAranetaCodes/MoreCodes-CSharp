<pre><code>
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

 namespace Problem12{

  //Problem 12: Write a program that asks a user for their
  //name and outputs a greeting with their name.

  class Program{
   static void Main(string[] args){
    String name = "";

    Console.Write("Enter your name: ");
    name = Console.ReadLine();
    Console.Write("Hello " + name);
    Console.ReadKey();
   }
  }
 }

</code></pre>
