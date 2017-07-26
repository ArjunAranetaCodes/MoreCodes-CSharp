using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9{

 //Problem 9: Write a program to display the multiplication
 //table of a given integer.

 class Program{
  static void Main(string[] args){
   int num = 2;
   for (int x = 0; x <= 10; x++){
    Console.WriteLine(num.ToString() + " x " +
     x.ToString() + " = " + (num * x).ToString());
   }
   Console.ReadKey();
  }
 }
}
