using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class IsValid
    {
        public bool isValid(string s)
        {
            bool ifCorrect = true;
            int temp_int = 0;
            string temp_str;
            //判断是否是单数。
            if (s.Length != 0 && s.Length % 2 != 0)
            {
                ifCorrect = false;
                return ifCorrect;
            }
            temp_str = s;
            do
            {
                temp_str = temp_str.Replace("()", "");
                temp_str = temp_str.Replace("{}", "");
                temp_str = temp_str.Replace("[]", "");
                temp_int++;
            }
            while (temp_int <= s.Length / 2 && temp_str.Length != 0);

            if (temp_str.Length != 0)
            { ifCorrect = false; }

            return ifCorrect;
           
        }

       
    }
}
