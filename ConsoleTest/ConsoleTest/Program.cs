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
            IsPalindrome a = new IsPalindrome();
            Console.WriteLine("输入的测试结果为：{0}", a.isPalindrome("A man, a plan, a canal: Panama"));
            Console.ReadKey();
        }
    }
   

}
