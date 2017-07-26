using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16{

 //Problem 16: Write a program that compare two strings.

 class Program{
  static void Main(string[] args){
   String word1 = "More";
   String word2 = "Codes";

   if (word1 == word2){
    Console.WriteLine("Equal");
   }else{
    Console.WriteLine("Not Equal");
   }
   Console.ReadKey();
  }
 }
}
