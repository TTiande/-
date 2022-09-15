using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class FirstUniqChar
    {
        public int firstUniqChar(string s)
        {
            //字符串实现
            #region
            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
                    return i;
            }
            return -1;
            #endregion
            //哈希表
            #region
            //Dictionary<char, int> temp = new Dictionary<char, int>();
            //string temp_Str = "";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (!temp.ContainsKey(s[i]))
            //    {
            //        temp.Add(s[i], i);
            //    }
            //    else if (!temp_Str.Contains(s[i]))
            //        temp_Str += s[i];
            //}
            //for (int j = 0; j < temp_Str.Length; j++)
            //{
            //    temp.Remove(temp_Str[j]);
            //}
            //return temp.Count != 0 ? temp.ElementAt(0).Value : -1;
            #endregion

            
        }
    }
}
