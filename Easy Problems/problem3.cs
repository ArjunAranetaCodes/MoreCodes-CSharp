<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3{

 //Problem 3: Write a program that accepts length and
 //width of rectangle to find area.

 class Program{
  static void Main(string[] args){
   int length = 0;
   int width = 0;
   int area = 0;

   Console.Write("Enter value of length: ");
   length = Int32.Parse(Console.ReadLine());
   Console.Write("Enter value of width: ");
   width = Int32.Parse(Console.ReadLine());
   area = length * width;

   Console.WriteLine("Area of Rectangle is " + area.ToString());
   Console.ReadKey();
  }
 }
}

</code></pre>
