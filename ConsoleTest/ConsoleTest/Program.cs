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
            AddStrings a = new AddStrings(); ;
            Console.WriteLine(a.addStrings("456","77"));
            Console.ReadKey();
        }
    }
   

}
