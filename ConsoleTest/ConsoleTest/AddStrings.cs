using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class AddStrings
    {//字符串相加
        public string addStrings(string num1, string num2)
        {
            //相同长度。
            if (num1.Length > num2.Length) num2 = num2.PadLeft(num1.Length, '0');
            else num1 = num1.PadLeft(num2.Length, '0');
            //定义变量。
            char[] num1_ch = num1.ToArray();
            char[] num2_ch = num2.ToArray();
            char[] result = new char[num1.Length];
            char carry = (char)0;

            //开始循环计算。
            for (int i = num1.Length - 1; i > -1; i--)
            {
                result[i] = (char)(num1_ch[i] + num2_ch[i] + carry - '0');
                if (result[i] > '9') { carry = (char)1; result[i] = (char)(result[i] - 10); }
                else carry = (char)0;
            }
            string sum = new String(result);
            if (carry != 0)
            {
                sum = "1" + sum;
            }
            return sum;
        }
    }

}
