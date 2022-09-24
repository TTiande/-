using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class IsSubsequence
    {//判断子序列
        public bool isSubsequence(string s, string t)
        {//思路：如果s的字符位置大于前一个字符的话，就放到num字典里。否则false.
            Dictionary<char, int> num = new Dictionary<char, int>();
            int pre_Length = 0;
            int star_Index=0;

            foreach (char i in s)
            {
                if (!t.Contains(i)) return false;
                else {//t包含有该值，有两种情况。找出index,大于前一位则放入。小于前一位则false
                    t.IndexOf()
                }
                
            }
            return true;
        }
    }
}