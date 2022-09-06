using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class LongestCommonPrefix
    {
            public string longestCommonPrefix(string[] strs)
            {
                string sum = null;
                int tempIndex = 0;
                int minLength;
                bool control = true;

                minLength = MinLength(strs);
                char[] tempChar = strs[0].ToCharArray();
                for (int i = 0,index=0; i < minLength; i++,index++)
                {
                    if (control == false)
                    {
                        break;
                    }
                    for (int j = 0; j < strs.Length; j++)
                    {
                        tempIndex = strs[j].IndexOf(tempChar[i], i);
                        if (tempIndex != -1)
                        {
                            if (index != tempIndex) { control = false; break; }
                            if (j == strs.Length - 1) sum += tempChar[i];
                            index = tempIndex;
                        }
                        else
                        {
                            control = false;
                            break;
                        }
                    }
                }

                if (sum == null) return "";
                else return sum;


            }
            public int MinLength(string[] strs)
            {
                int min = strs[0].Length;
                for (int a = 0; a < strs.Length; a++)
                {
                    if (strs[a].Length < min) min = strs[a].Length;
                }
                return min;
            }
        }

}
