using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class AddStrings
    {
        public string addStrings(string num1, string num2)
        {
            //使他们的长度一样。
            if (num1.Length > num2.Length)
                num2=num2.PadLeft(num1.Length, '0');
            else num1=num1.PadLeft(num2.Length, '0');

            int carry = 0;
            char[] num_1 = num1.ToArray();
            char[] num_2 = num2.ToArray();
            StringBuilder result = new StringBuilder();
            Array.Reverse(num_1);
            Array.Reverse(num_2);
            
            for (int i = 0; i < num1.Length; i++)
            {
                char a = (char)(num_1[i] +num_2[i] + carry-48);
                if (a > '9') { carry = 1; result.Append((char)(a-48)); }
                else { carry = 0; result.Append(a); }
            }
            char[] result_char=new char[result.Length];
            result_char = result.ToString().ToArray();
            Array.Reverse(result_char);
            string b = new String(result_char);
            return b;
        }
    }

}
