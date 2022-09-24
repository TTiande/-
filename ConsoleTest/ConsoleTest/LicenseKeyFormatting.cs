using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class LicenseKeyFormatting
    {//密钥格式化
        public string licenseKeyFormatting(string s, int k)
        {
            String str = s.Replace("-", "");
            if (str == "") return "";
            StringBuilder temp = new StringBuilder();
            Stack<String> stack = new Stack<String>();
            
            int lenth = str.Length / k;
            for (int i = 0; i < lenth; i++)
            {
                string a=str.Substring(str.Length-k);
                stack.Push(a);
                stack.Push("-");
                str=str.Remove(str.Length-k);
            }
            if (str.Length % k != 0) stack.Push(str);
            if (stack.Peek() == "-") stack.Pop();
            string result=String.Join("", stack.ToArray());
            result=result.ToUpper();
            return result;
        }
    }
}
