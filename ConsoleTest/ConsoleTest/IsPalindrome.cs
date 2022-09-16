using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleTest
{
    class IsPalindrome
    {
        public bool isPalindrome(string s)
        {
            
            object[] ob_str = null;
            Stack st = new Stack();

            //去掉所有空白；
            s=s.Replace(" ", "");
            s=s.ToLower();
            //利用栈插入所有的字母数字
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] <= 57 & s[i] >= 48 || s[i] <= 90 & s[i] >= 65 || s[i] <= 122 & s[i] >= 97)
                    st.Push(s[i]);
            }
            ob_str = st.ToArray();

            string[] str = Array.ConvertAll<object, string>(ob_str, x => x.ToString());
            if (str.Length == 0)
            {
                return true;
            }
            StringBuilder a = new StringBuilder();
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                a.Append(str[i]);
                b.Append(str[str.Length - 1 - i]);
            }

            bool F = a.Equals(b);
            return F;
        }
    }
}
