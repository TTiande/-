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
            FizzBuzz a = new FizzBuzz();;
            foreach(var i in a.fizzBuzz(3))
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
   

}
