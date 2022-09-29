using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class ReverseStr
    {//反转字符串II
        public string reverseStr(string s, int k)
        {

            //1.判断s和k是否能构成整数倍关系。如果能执行d3步，如果不能进行d2步。
            //2.执行不能2K的尾数，剩下的执行3步。
            //3.循环执行
            
            if (s.Length % (2 * k) == 0) return Reverse_Str(s, k);
            else
            {
                string temp = Reverse_Str(s.Substring(s.Length - s.Length % (2 * k)), k);
                return Reverse_Str(s.Substring(0, s.Length - s.Length % (2 * k)), k) + temp;
            }
        }
        public string Reverse_Str(string s, int k)
        {
            string result = "";
            if (s.Length >=(2* k))
            {//循环反转k个字符
                int i = 0;
                while (i < s.Length / (2 * k))
                {
                    string childstr = "";
                    int startIndex =1+2*i;
                    if(startIndex==1) childstr=s.Substring(0,k);
                    else childstr =s.Substring(startIndex, startIndex+k);
                    Child(s, k, ref childstr);
                    result += childstr;
                    if (startIndex == 1) result += s.Substring( k, k);
                    else result += s.Substring(startIndex + k, k);
                    i++;
                }
            }
            else if (s.Length < (2 * k) && s.Length > k)
            {//反转k个字符，后者不变
                string childstr = s.Substring(0, k);
                Child(s, k, ref childstr);
                result += childstr;
                result +=s.Substring(k);
            }
            else
            {//全部反转
                string childstr = s;
                Child(s, k, ref childstr);
                result += childstr;
            }
            return result;
        }
        public void Child(string s, int k,ref string childstr)
        {
            char[] a = childstr.ToCharArray();
            for (int j = 0; j < k/2; j++)
            {
                char b = a[j];
                a[j] = a[k - 1];
                a[k - 1] = b;
            }
            childstr = new string(a);
        }

    }
}
