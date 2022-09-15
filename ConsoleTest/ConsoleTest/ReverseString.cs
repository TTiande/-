using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class ReverseString
    {//反转字符串
        public char[] s = new char[5] { 'h','e','l','l','o'};
        public void reverseString(char[] s)
        {
            char temp = new char();
            for (int i = 0; i < s.Length/2; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }
    }
}
