using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class CanConstruct
    {
        //赎金信
        public bool canConstruct(string ransomNote, string magazine)
        {
            //方法一
            //int[] temp1 = new int[26];
            //int[] temp2 = new int[26];

            //for (int i = 0; i < ransomNote.Length; i++)
            //{
            //    temp1[ransomNote[i] - 'a']++;
            //}
            //for (int j = 0; j < magazine.Length; j++)
            //{
            //    temp2[magazine[j] - 'a']++;
            //}
            //for (int k = 0; k < 26; k++)
            //{
            //    if (temp1[k] != 0)
            //    {
            //        if (temp1[k] > temp2[k])
            //            return false;
            //    }
            //}
            //return true;
            //方法二 哈希
            List<char> temp1 = new List<char>();
            for (int i = 0; i < ransomNote.Length; i++)
            {
                temp1.Add(ransomNote[i]);
            }
            for (int j = 0; j < magazine.Length; j++)
            {
                if (temp1.Contains(magazine[j]))
                {
                    temp1.Remove(magazine[j]);
                }
                else continue;
            }
            return temp1.Count == 0 ? true : false;
        }
    }
}
