using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class AddBinary
    {
        public string addBinary(string a, string b)
        {
            int carry = 0;
            int temp = 0;
            string sum = null ;
            int minLength = (a.Length > b.Length) ? b.Length : a.Length;
            int maxLength = (a.Length > b.Length) ? a.Length : b.Length;

            for (int i = 0; i < minLength; i++)
            {
                int num1 = Convert.ToInt32(a[a.Length - 1 - i]);
                int num2 = Convert.ToInt32(b[b.Length - 1 - i]);
                //判断是否有进位
                if (temp != 0)
                {
                    temp = 1 + num1 + num2;
                }
                else
                {
                    temp = num1 + num2;
                }
                //插入结果
                if (temp > 1)
                {
                    carry = 1;
                    if (temp > 2) sum = sum.Insert(0, "1");
                    else sum = sum.Insert(0, "0");
                }
                else if (temp == 1)
                {
                    carry = 0;
                    sum = sum.Insert(0, "1");
                }
                else
                {
                    carry = 0;
                    sum = sum.Insert(0, "0");
                }
            }

            if (carry != 0)
            {
                sum = sum.Insert(0, "1");
            }
            return sum;
        }
    }
}
