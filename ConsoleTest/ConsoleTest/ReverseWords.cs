using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class ReverseWords
    {//反转字符串中的单词III

        public string ReverseWords(string s)
        {
            string[] s_array = s.Split(new char[1] { ' ' });
            for (int i = 0; i < s_array.Length; i++)
            {
                s_array[i] = Rever(s_array[i]);
            }
            return String.Join(" ", s_array);
        }
        public string Rever(string str)
        {
            StringBuilder s = new StringBuilder(str);
            char temp;
            for (int i = 0; i < s.Length / 2; i++)
            {
                temp = str[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
            return s.ToString();
        }
    }
}
