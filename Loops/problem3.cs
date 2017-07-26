using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3{

 //Problem 3: Write a program that count letters in a
 //string using a loop.

 class Program{
  static void Main(string[] args){
  string word = "MoreCodes";
  int count = 0;

  foreach (char element in word){
   count = count + 1;
  }

  Console.WriteLine("String Length: " + count.ToString());
  Console.ReadKey();
  }
 }
}
