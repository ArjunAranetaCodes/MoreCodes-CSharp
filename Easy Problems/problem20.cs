<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20{

 //Problem 20: Write a program that checks if a string is a
 //palindrome.

 class Program{
  static void Main(string[] args){
   String word = "anna";
   char[] temp = word.ToCharArray();
   Array.Reverse(temp);
   String tempWord = new string(temp);

   if (word == tempWord){
    Console.Write("Palindrome");
   }else{
    Console.Write("Not Palindrome");
   }

   Console.ReadKey();
  }
 }
}

</code></pre>
