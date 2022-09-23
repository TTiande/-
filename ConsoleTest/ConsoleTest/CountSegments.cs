using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{//字符串中的单词数。
    class CountSegments
    {
        public int countSegments(string s)
        {
            int result = 0;
            char alphabet = ' ';
            s = s.Trim();
            if (s.Length == 0)
            {
                return 0;
            }
            string[] temp = s.Split(alphabet);
            foreach (var i in temp)
            {
                if (i != "") result++;
            }
            return result;
        }
    }
}
