using System;
namespace basicinput{
 //Variables and Input
 class Program{
  static void Main(string[] args){
   string name = "";
   char sex;
   int age = 0;

   Console.Write("What is your name? ");
   name = Console.ReadLine();
   Console.Write("What is your sex? ");
   sex = char.Parse(Console.ReadLine());
   Console.Write("What is your age? ");
   age = Int32.Parse(Console.ReadLine());

   Console.WriteLine();
   Console.WriteLine("Name: " + name);
   Console.WriteLine("Sex: " + sex);
   Console.WriteLine("Age: " + age);
   Console.ReadKey();
  }
 }
}
