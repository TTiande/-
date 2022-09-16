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
            FindTheDifference a = new FindTheDifference();
            Console.WriteLine(a.findTheDifference("abcd","abcde"));
            Console.ReadKey();
        }
    }
   

}
