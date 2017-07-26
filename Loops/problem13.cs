<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13{

 //Problem 13: Write a program that reverses a string.

 class Program{
  static void Main(string[] args){
   string word = "MoreCodes";
   string newWord = "";

   for (int x = word.Length - 1; x >= 0; x--){
    newWord = newWord + word.Substring(x, 1);
   }
   Console.WriteLine(newWord);
   Console.ReadKey();
  }
 }
}

</code></pre>
