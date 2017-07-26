using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11{

 //Problem 11: Write a program that checks if a number
 //is palindrome.

 class Program{
  static void Main(string[] args){
   int num = 3333;
   int sum = 0;
   int temp = 0;
   int rmdr = 0;

   temp = num;

   while (temp != 0){
    rmdr = temp % 10;
    sum = sum * 10 + rmdr;
    temp = temp / 10;
   }

   if (num == sum){
    Console.WriteLine("Palindrome number");
   }else{
    Console.WriteLine("Not a Palindrome number");
   }
   Console.ReadKey();
  }
 }
}
