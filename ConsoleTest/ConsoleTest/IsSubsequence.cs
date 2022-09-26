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
            int[,] dp = new int[s.Length + 1, t.Length + 1];
            dp[0, 0] = 0;
            int res = 0;

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= t.Length; j++)
                {
                    if (s[i - 1] == t[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = dp[i, j - 1];
                    res = Math.Max(res, dp[i, j]);
                }
            }
            return res == s.Length;

        }
    }
}