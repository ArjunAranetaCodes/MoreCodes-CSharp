using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14{

 //Problem 14: Write a program that accepts 5 numbers
 //and outputs the average.

 class Program{
  static void Main(string[] args){
   int num = 0;
   int sum = 0;
   int ave = 0;

   for (int x = 0; x < 5; x++){
    Console.Write("Enter a number: ");
    num = Int32.Parse(Console.ReadLine());
    sum = sum + num;
   }
   ave = sum / 5;
   Console.WriteLine("Average is " + ave.ToString());
   Console.ReadKey();
  }
 }
}
