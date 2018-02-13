//Problem 9: Write a program that converys a hexadecimal number to decimal number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = 0;
            string hex = "100";

            char[] temp = hex.ToCharArray();
            Array.Reverse(temp);
            hex = new string(temp);

            for (int x = 0; x < hex.Length; x++)
            {
                dec = dec + (Convert.ToInt32(hex[x].ToString()) * 
                    Convert.ToInt32(Math.Pow(16, x)));
            }

            Console.WriteLine(dec);
            Console.ReadKey();

        }
    }
}
