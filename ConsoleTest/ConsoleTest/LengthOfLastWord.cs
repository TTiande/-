using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class LengthOfLastWord
    {
        public int lengthOfLastWord(string s)
        {
            string[] str;
            int length;
            char[] temp = new char[1] { ' ' };

            str = s.Split(temp);
            length = str[str.Length - 1].Length;
            return length;
        }
    }
}
