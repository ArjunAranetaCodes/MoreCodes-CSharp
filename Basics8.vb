using System;

namespace switch_case{
 //Switch Statement
 class Program{
  static void Main(string[] args){
   int num1 = 10;

   switch(num1){
    case 1:
     Console.WriteLine("Seems it is number 1");
     break;
    case 5:
    case 10:
     Console.WriteLine("Feels like it is five or 10");
     break;
   }

   Console.ReadKey();
  }
 }
}
