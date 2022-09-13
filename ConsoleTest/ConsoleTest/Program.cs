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
            TitleToNumber a = new TitleToNumber();
            Console.WriteLine("输入的测试结果为：{0}", a.titleToNumber("AB"));
            Console.ReadKey();
        }
    }
   

}
