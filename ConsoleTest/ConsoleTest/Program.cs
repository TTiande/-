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
            AddBinary a = new AddBinary();
            Console.WriteLine("输入的测试结果为：{0}", a.addBinary("11","1"));
            Console.ReadKey();
        }
    }
   

}
