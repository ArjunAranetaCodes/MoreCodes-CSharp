using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17{

 //Problem 18: Write a program that outputs the frequency of a
 //letter in a string.

 class Program{
  static void Main(string[] args){
   String word = "program";
   String letter = "a";
   int letterCount = 0;

   for (int i = 0; i < word.Length - 1; i++){
    if (letter.Contains(word.Substring(i,1))){
     letterCount += 1;
    }
   }

   Console.WriteLine("Total: " + letterCount.ToString());
   Console.ReadKey();
  }
 }
}
