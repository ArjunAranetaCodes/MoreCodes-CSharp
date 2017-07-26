<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4{

 //Problem 4:Write a program that accepts radius of a circle and
 //find its diameter, circumference, and area.

 class Program{
  static void Main(string[] args){
   int radius = 0;
   double PI = 3.14, dia = 0.0, area = 0.0, cir = 0.0;

   Console.Write("Enter radius value: ");
   radius = Convert.ToInt32(Console.ReadLine());

   dia = radius * radius;
   area = PI * dia;
   cir = 2 * PI * radius;

   Console.WriteLine("Diameter of circle is " + dia.ToString());
   Console.WriteLine("Area of circle is " + area.ToString());
   Console.WriteLine("Circumference of circle is " + cir.ToString());
   Console.ReadKey();
  }
 }
}

</code></pre>
