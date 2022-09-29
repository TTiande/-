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
            ReverseStr a = new ReverseStr();
            Console.WriteLine(a.reverseStr("abcdef", 2));
            Console.ReadKey();
        }
    }


}
