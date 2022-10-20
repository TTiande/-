using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class LongestPalindromeII
    {//最长回文子串（难度：中等）
        public string longestPalindromeII(string s)
        {
            return "";
            //暴力破解，超出时间限制
            //string temp = null;
            //string result = "";
            //for (int i = 0; i < s.Length - 1; i++)
            //{
            //    int j = 0;
            //    for (j=i+1 ; j < s.Length; j++)
            //    {
            //        temp = s.Substring(i, j - i + 1);
            //        char[] a=temp.ToCharArray();
            //        Array.Reverse(a);
            //        string b=new string(a);
            //        if (temp == b) result = result.Length > temp.Length ? result : temp;
            //    }
            //}
            //return result = result.Length == 0 ? s[0].ToString() : result;
        }
    }
}
