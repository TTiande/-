using System;
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
            //思路三：KMP算法:1.实现Next数组。2.遍历主串。
            //int[] next=new int[];
             var nextArray = GetKMPNextArray(s);
            var tailIndex = s.Length - 1;
            return nextArray[tailIndex] != -1 && s.Length % (tailIndex - nextArray[tailIndex]) == 0;
            //实现2
            //StringBuilder str = new StringBuilder();
            //StringBuilder temp = new StringBuilder();
            //if (s.Length < 2) return false;
            //for (int i = 0; i < s.Length/2+1; i++)
            //{
            //    if (!temp.ToString().Contains(s[i])) { temp.Append(s[i]); continue; }
            //    string temp_Str= temp.ToString();
            //    temp.Append(s[i]);
            //    if (s.Length % temp_Str.Length != 0) continue;
            //    str=str.Clear();
            //    for (int j = 0; j < s.Length / temp_Str.Length; j++) str=str.Append(temp_Str);
                
            //    if (str.ToString() == s) return true; else continue;
            //}
            //return false;
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
        
        private int[] GetKMPNextArray(string s)
        {
            var test = Enumerable.Repeat(-1, s.Length);
            var forReturn = test.ToArray();
            for (var i = 1; i < s.Length; i++)
            {
                var j = forReturn[i - 1];
                while (j >= 0 && s[j + 1] != s[i])
                    j = forReturn[j];

                if (s[j + 1] == s[i])
                    forReturn[i] = j + 1;
            }

            return forReturn;
        }
    }
}
