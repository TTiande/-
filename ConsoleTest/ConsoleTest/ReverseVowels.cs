using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class ReverseVowels
    {
        public string reverseVowels(string s)
        {

            int i = 0, j = s.Length - 1,control=j;
            char[] s_Char = s.ToArray();
            char temp = new char();
            char[] vowel = new char[10] { 'a', 'e', 'i', 'o', 'u' ,'A','E','I','O','U'};
            if (s.IndexOfAny(vowel) == -1) return s;
            for (; i < control; i++)
            {
                if (vowel.Contains(s_Char[i]))
                {
                    for (j=control; j > i; j--)
                    {
                        if (vowel.Contains(s_Char[j]))
                        {
                            temp = s_Char[i];
                            s_Char[i] = s_Char[j];
                            s_Char[j] = temp;
                            control = j - 1;
                            break;
                        }
                    }
                }

            }
            return new String(s_Char);

        }
    }
}
