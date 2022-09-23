﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class RepeatedSubstringPattern
    {//重复的子字符串
        public bool repeatedSubstringPattern(string s)
        {//思路1：长度为0或1返回false。重复与首字母进行判断，用队列最方便。
            //思路2：用Compare方法或Equals方法进行判断,反复比较。
            StringBuilder str = new StringBuilder(s);
            Stack<char> temp = new Stack<char>();
            if (s.Length < 2) return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (temp.Contains(s[i])) { temp.Push(s[i]); continue; }
                string temp_Str=temp.ToString();
                if (s.Length % temp_Str.Length != 0) continue;
                
            }
            //实现1
            //StringBuilder str = new StringBuilder();
            //if (s.Length < 2) return false;
            //for (int i = 0; i < s.Length / 2; i++)
            //{
            //    str.Append(s[i]);
            //    string temp = str.ToString();
            //    string test = temp;
            //    while (test.Length < s.Length)
            //    {
            //        test = String.Concat(test, temp);
            //    }
            //    if (test != s || test.Length > s.Length) continue; else return true;
            //}
            //if (s.Length % 2 != 0)
            //{
            //    string a = s[0].ToString(); a = a.PadLeft(s.Length, s[0]);
            //    if (a != s) return false; else return true;
            //}
            //return false;
        }
    }
}
