using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class FindLUSlength
    {//最长特殊序列 I
        public int findLUSlength(string a, string b)
        {
            //1.求出各自的最长特殊序列。
            //2.判断
            if (a != b) return a.Length > b.Length ? a.Length : b.Length;
            else return -1;
        }
    }
}
