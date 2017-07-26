using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12{

 //Problem 12: Calculate the Product of two numbers
 //WITHOUT using the * operator.

 class Program{
  static void Main(string[] args){
   int num1 = 3;
   int num2 = 5;
   int prod = 0;

   for (int x = 1; x <= num2; x++){
    prod = prod + num1;
   }
   Console.WriteLine("3 * 5 = " + prod.ToString());
   Console.ReadKey();
  }
 }
}
