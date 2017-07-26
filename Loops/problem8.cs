<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8{

 //Problem 8: Write a program that counts vowels in a string.

 class Program{
  static void Main(string[] args){
   String word = "program";
   String letter = "aeiou";
   int letterCount = 0;

   for (int i = 0; i < word.Length - 1; i++){
    if (letter.Contains(word.Substring(i, 1))){
     letterCount += 1;
    }
   }
   Console.WriteLine("Total Vowels: " + letterCount.ToString());
   Console.ReadKey();
  }
 }
}

</code></pre>
