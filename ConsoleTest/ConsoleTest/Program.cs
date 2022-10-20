using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            char temp = 'a';
            Console.WriteLine(temp.GetType());
            LongestPalindrome a = new LongestPalindrome();
            Console.WriteLine(a.longestPalindrome("abccccdd"));
            Console.ReadKey();
        }

    }
}
