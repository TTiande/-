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
            LengthOfLastWord a = new LengthOfLastWord();
            Console.WriteLine("输入的测试结果为：{0}", a.lengthOfLastWord("   fly me   to   the moon  "));

            Console.WriteLine(typeof(Int32.Parse("3")));
            Console.ReadKey();
        }
    }
   

}
