using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleTest
{
    class Class1
    {
        public Type function(string s)
        {
            char a = 'a';
            int b = 97;
            bool c = false;
            var d=a-b;
            return d.GetType();
             s = Regex.Replace(s,"[^A-Z0-9a-z]*","").ToLower();

            char[] temp = s.ToCharArray();

            Array.Reverse(temp);

            //return s == new string(temp);
        }
    }
}
