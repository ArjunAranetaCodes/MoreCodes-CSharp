<pre><code>
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

 namespace Problem14{

  //Problem 14: Write a program that replaces all letter
  //a' in a string with letter 'e'

  class Program{
   static void Main(string[] args){
    String word = "program";
    String newWord = word.Replace("a", "e");
    Console.WriteLine(newWord);
    Console.ReadKey();
   }
  }
 }

</code></pre>
