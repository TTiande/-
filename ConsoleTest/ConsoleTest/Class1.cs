using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleTest
{
    class Class1
    {
        public Type function()
        {
            //1
            //string a = "4";
            //int b = 1;
            //int temp = 0;
            //bool d=int.TryParse(a, out temp);
            //var sum = temp - b;
            //2
            //char a = 'a';
            //string b = a.ToString();
            //var result = b.ToCharArray();
            //3
            char a = 'a';
            int b = 1;
            var result = char.Parse(b.ToString());
            return result.GetType();
            //return s == new string(temp);
        }
    }
}
