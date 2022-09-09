using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleTest
{
    class Class1
    {
        public bool function(string s)
        {
             s = Regex.Replace(s,"[^A-Z0-9a-z]*","").ToLower();

            char[] temp = s.ToCharArray();

            Array.Reverse(temp);

            return s == new string(temp);
        }
    }
}
