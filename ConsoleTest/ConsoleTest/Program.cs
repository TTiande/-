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
            ReverseString a = new ReverseString();
            a.reverseString(a.s);
            a.s.ToString();
            Console.WriteLine( a.s);
            Console.ReadKey();
        }
    }
   

}
