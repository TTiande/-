using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class LongestPalindrome
    {//破题目。最长回文串，贪心算法实现。
        public int longestPalindrome(string s)
        {
            Char[] s_Char = s.ToArray();
            if (s.Length < 2) return s.Length;
            Stack<Char> stack = new Stack<Char>();
            Stack<Char> result = new Stack<Char>();
            int num = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!stack.Contains(s[i])) { stack.Push(s[i]); continue; }
                StringBuilder temp = new StringBuilder();
                int length=stack.Count;
                for (int j = 0; j < length; j++)
                {
                    if (stack.Peek() != s[i])
                    { temp.Append(stack.Pop()); }
                    else
                    {
                        result.Push(s[i]); result.Push(s[i]);
                        stack.Pop();
                        for (int k = 0; k < temp.Length; k++)
                        {
                            stack.Push(temp[k]);
                        }
                        break;
                    }

                }
            }
            if (result.Count % 2 == 0) { num = result.Count; return num < s.Length ? ++num : num; }
            else return result.Count;
        }
    }
}
