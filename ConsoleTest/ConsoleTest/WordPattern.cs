using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    //单词规律
    class WordPattern
    {
        public bool wordPattern(string pattern, string s)
        {
            string[] str = s.Split(' ');
            int aP = 0, bS = 0;
            if (str.Length != 0 & pattern.Length == str.Length)
            {
                Dictionary<string, string> patternToStr = new Dictionary<string, string>();
                for (int i = 0; i < str.Length; i++)
                {
                    if (!patternToStr.ContainsKey(str[i]))
                    {
                        if (!patternToStr.ContainsValue(pattern[i].ToString())) aP++;
                        patternToStr.Add(str[i], pattern[i].ToString());
                        bS++;

                    }
                    else
                    {
                        if (patternToStr[str[i]] != pattern[i].ToString())
                            return false;
                    }
                }
                if (aP != bS) return false;

            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
