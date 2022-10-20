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
            string temp=null;
            try
            {
                char[] a = x.ToString().ToCharArray();
                 temp= new string(a);
                 if (temp == x.ToString()) return true;
                 else return false;
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("已经判断完毕。");
            }
            return false;
        }
        
    }
}
