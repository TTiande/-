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
            CanConstruct a = new CanConstruct();
            Console.WriteLine(a.canConstruct("a","b"));
            Console.ReadKey();
        }
    }
   

}
