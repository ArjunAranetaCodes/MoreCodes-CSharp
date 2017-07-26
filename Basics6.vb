using System;

namespace Loops{
 //Loop Structures
 class Program{
  static void Main(string[] args){
   int x = 0;
   Console.WriteLine("For Loop");
   for (x = 0; x <= 10; x++){
    Console.Write(x);
   }

   Console.Write("\n\n");
   Console.WriteLine("While Loop");
   x = 0;
   while (x <= 10){
    Console.Write(x);
    x++;
   }

   Console.Write("\n\n");
   Console.WriteLine("Do Loop");
   x = 0;
   do{
    Console.Write(x);
    x++;
   } while (x <= 10);

   Console.ReadKey();
  }
 }
}
