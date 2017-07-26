<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1{

 //Problem 1: Write a program that prints the numbers from 1 to 50.
 //Output "Fizz" for multiples of 3, output "Buzz" for multiples of 5, and
 //both "FizzBuzz" for multiples of both 3 and 5.

 class Program{
  static void Main(string[] args){
   for (int x = 0; x <= 50; x++){
    if ((x % 3 == 0) && (x % 5 == 0)){
     Console.WriteLine("FizzBuzz");
    }else if (x % 3 == 0){
     Console.WriteLine("Fizz");
    }else if (x % 5 == 0){
     Console.WriteLine("Buzz");
    }else{
     Console.WriteLine(x);
    }
   }
   Console.ReadKey();
  }
 }
}

</code></pre>
