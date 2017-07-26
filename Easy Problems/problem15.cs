 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

 namespace Problem15{

  //Problem 15: Write a program that finds if a string is
  //within a string.

  class Program{
   static void Main(string[] args){
    String word = "programming";
    String strSearch = "program";
    if (word.Contains(strSearch)) {
     Console.WriteLine(strSearch + " Found");
    }
    else
    {
     Console.WriteLine(strSearch + " Not Found");
    }
    Console.ReadKey();

   }
  }
 }
