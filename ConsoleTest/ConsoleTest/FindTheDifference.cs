using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class FindTheDifference
    {
        public char findTheDifference(string s, string t)
        {
            int[] a = new int[26];
            foreach (var i in s)
            {
                a[i - 'a']++;
            }
            foreach (var i in t)
            {
                a[i - 'a']--;
            }
            int b = Array.IndexOf(a, -1);
            
            return  Convert.ToChar(b+97);
        }
    }
}
