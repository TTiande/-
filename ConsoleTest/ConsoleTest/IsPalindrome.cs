using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleTest
{
    class IsPalindrome
    {
        public bool isPalindrome(string s)
        {
            Char[] str;
            Stack st = new Stack();

            //去掉所有空白；
            s.Replace(" ", "");
            //利用栈插入所有的字母数字
            str = s.ToCharArray();

        }
    }
}
