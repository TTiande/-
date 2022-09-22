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
            LongestPalindrome a = new LongestPalindrome(); ;
            Console.WriteLine(a.longestPalindrome("abccccdd"));
            Console.ReadKey();
        }
    }
   

}
