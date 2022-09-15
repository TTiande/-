using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseVowels a = new ReverseVowels();
            Console.WriteLine(a.reverseVowels("leetcode"));
            Console.ReadKey();
        }
    }
   

}
