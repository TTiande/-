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
            FindLUSlength a = new FindLUSlength();
            Console.WriteLine(a.findLUSlength("aba","cdc"));
            Console.ReadKey();
        }
    }


}
