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
           // //使用s的每一个字符遍历匹配t字符串
           // //如果首个字符匹配到,那么切换到下一个字符继续匹配
           //StringBuilder str = new StringBuilder(t);
           // int a=0;
           // for (int i = 0; i < s.Length; i++)
           // {
           //     string temp=str.ToString();
           //     if(!temp.Contains(s[i]))return false;
           //     if(!t.Contains(s[i]))return false;
           //     if(i>0 && )
           //         str.Remove(temp.IndexOf(s[i]),1);
           //     a=t.IndexOf(s[i],0);
           // }
            return true;
        }
    }
}
