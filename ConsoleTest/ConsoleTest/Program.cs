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
            FindWords a = new FindWords(); 
            string[] result=a.findWords(new string[] { "Hello","Alaska","Dad","Peace"});
            foreach(var i in result)
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }


}
