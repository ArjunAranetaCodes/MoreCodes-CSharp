using System;

namespace functions{
 //Basics of Functions
 class Program{
  static void Main(string[] args){
   function1();
   function2(5);
   Console.WriteLine("It's true! 1+1 = " + function3());
   Console.WriteLine("Hi " + function4("More","Codes"));
   Console.ReadKey();
  }

  //function that has no return value and no passing argument/parameter
  static void function1(){
   Console.WriteLine("Hello there!");
  }

  //function that has no return value but has passing argument/parameter
  static void function2(int num){
   Console.WriteLine("That number is " + num);
  }

  //function that has return value but has no passing argument/parameter
  static int function3() {
   int sum = 1 + 1;
   return sum;
  }

  //function that has return value and has passing argument/parameter
  static string function4(string firstName, string lastName){
   string fullName = firstName + " " + lastName;
   return fullName;
  }
 }
}
