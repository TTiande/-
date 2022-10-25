using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_in__Leetcode
{
    class IsPalindrome
    {
        public static bool isPalindrome(int x)
        {
            string temp=String.Empty;
            try
            {
                char[] a = x.ToString().ToCharArray();
                Array.Reverse(a);
                 temp= new string(a);
                 
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("已经判断完毕。");
            }

            if (temp == x.ToString()) return true;
            else return false;
        }
        
    }
}
