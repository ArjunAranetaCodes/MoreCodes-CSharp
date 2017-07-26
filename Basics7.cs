using System;

namespace if_else{
 //If, ElseIf, and Else Structure
 class Program{
  static void Main(string[] args){
   int num1 = 1,
   num2 = 2;

   //if statement
   if(num1>num2){
    Console.WriteLine("First number is higher!");
   }

   //if-else statement
   if(num1==num2){
    Console.WriteLine("They are equal!");
   }else{
    Console.WriteLine("They are not equal!");
   }

   //if-else if statement
   if(num1>num2){
    Console.WriteLine("First number is greater!");
   }else if(num1<num2){
    Console.WriteLine("Second number is greater!");
   }

   Console.ReadKey();
  }
 }
}
