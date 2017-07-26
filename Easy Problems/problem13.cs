 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

 namespace Problem13{

  //Problem 13: Write a program that outputs the length
  //of the string.

  class Program{
   static void Main(string[] args){
    String word = "MoreCodes";
    int strLength = word.Length;
    Console.WriteLine("String Length: " + strLength.ToString());
    Console.ReadKey();
   }
  }
 }
