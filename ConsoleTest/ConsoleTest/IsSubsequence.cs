using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class IsSubsequence
    {//判断子序列
        public bool isSubsequence(string s, string t)
        {
            //使用s的每一个字符遍历匹配t字符串
        //如果首个字符匹配到,那么切换到下一个字符继续匹配
        int rightcount = 0;
        for (int i = 0; i < s.Length; i++) 
        {
            for (int j = 0; j < t.Length; j++) 
            {
                if (s[i] == t[j]) 
                {
                    i++;
                    rightcount++;
                }
                   if(i>=s.Length)
                    break;
            }

        }
        if(rightcount==s.Length)
            return true;
        else
            return false;

        }
    }
}
