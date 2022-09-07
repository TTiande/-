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
            string sum = "" ;
            int minLength = (a.Length > b.Length) ? b.Length : a.Length;
            int maxLength = (a.Length > b.Length) ? a.Length : b.Length;

            //相同长度字符串
            if (a.Length > b.Length) b=b.PadLeft(a.Length, '0');
            else a=a.PadLeft(b.Length, '0');

            for (int i = 0; i < maxLength; i++)
            {
                
                int num1 = Convert.ToInt32(a[a.Length - 1 - i])-'0';
                int num2 = Convert.ToInt32(b[b.Length - 1 - i])-'0';
                //判断是否有进位
                if (carry != 0)
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
