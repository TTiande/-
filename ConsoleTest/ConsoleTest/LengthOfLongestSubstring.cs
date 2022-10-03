using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class LengthOfLongestSubstring
    {//无重复字符的最长字串(难度：中等)
        public int lengthOfLongestSubstring(string s)
        {
            int left = 0, right = 0, max = 0;
            StringBuilder temp = new StringBuilder();

            if (s.Length == 0) return 0;
            while (right < s.Length)
            {
                right++;
                string a = temp.ToString();
                if (a.Contains(s[right - 1]))
                {
                    left++;
                    right = left + 1;
                    max = temp.Length > max ? temp.Length : max;
                    temp.Clear();
                    temp.Append(s[right - 1]);
                }
                else temp.Append(s[right - 1]);
            }
            max = temp.Length > max ? temp.Length : max;
            return max;
        }
    }
}
