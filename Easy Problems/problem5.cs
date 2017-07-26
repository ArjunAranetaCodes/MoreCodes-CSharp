<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5{

 //Problem 5: Write a program that accepts that accepts temperature in
 //Celcius and convert it to Farenheit.

 class Program{
  static void Main(string[] args){
   double celsius = 0, farenheit = 0;

   Console.Write("Enter celsius value: ");
   celsius = Convert.ToInt32(Console.ReadLine());

   farenheit = (9.0 / 5.0) * celsius + 32.0;

   Console.WriteLine(celsius.ToString() + "C equals to " +
   farenheit.ToString() + "F");

   Console.ReadKey();
  }
 }
}

</code></pre>
