<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem18{

 //Problem 18: (Recursion) Write a program that outputs the
 //fibonacci sequence of a number.

 class Program{
 static void Main(string[] args){
  for (int x = 0; x <= 11; x++){
   Console.WriteLine(Fibonacci(x));
  }
  Console.ReadKey();
 }

 static int Fibonacci(int num){
  if ((num == 1) || (num == 0)){
   return num;
  }else{
   return Fibonacci(num - 1) + Fibonacci(num - 2);
  }
 }
 }
}

</code></pre>
