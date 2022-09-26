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
            DetectCapitalUse a = new DetectCapitalUse();
            Console.WriteLine(a.detectCapitalUse("ffffffffffffffffffffF"));
            Console.ReadKey();
        }
    }


}
