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
            ConvertToTitle a = new ConvertToTitle();
            Console.WriteLine("输入的测试结果为：{0}", a.convertToTitle(701));
            Console.ReadKey();
        }
    }
   

}
