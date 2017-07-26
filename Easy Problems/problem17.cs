using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19{

 //Problem 17: Write a program that outputs the index
 //of the first occurrence of the letter in a string.

 class Program{
  static void Main(string[] args){
   String word = "program";
   String letter = "a";

   if (word.Contains(letter)){
    Console.WriteLine("Contains a");
   }
   else{
    Console.WriteLine("Does not contain a");
   }
   Console.ReadKey();
  }
 }
}
