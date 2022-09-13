using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class IsIsomorphic
    {
        public bool isIsomorphic(string s, string t)
        {
            Dictionary<char, char> a = new Dictionary<char, char>();
            Dictionary<char, char> b = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!a.ContainsKey(s[i]))
                {
                    if (b.ContainsKey(t[i])) return false;
                    a.Add(s[i], t[i]);
                    b.Add(t[i], s[i]);
                }
                else
                {
                    if (a[s[i]] != t[i])
                        return false;
                }
            }
            return true;
        }
    }
}
