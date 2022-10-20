using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_in__Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome temp = new IsPalindrome();
            bool a=IsPalindrome.isPalindrome(-123);
            Console.WriteLine(a);
            Console.Read();
        }
    }
}
