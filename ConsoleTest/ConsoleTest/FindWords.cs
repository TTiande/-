using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class FindWords
    {//键盘行
        public string[] findWords(string[] words)
        {
            List<String> list = new List<String>();
            string one = "qwertyuiopQWERTYUIOP", two = "asdfghjklASDFGHJKL", three = "zxcvbnmZXCVBNM";
            string temp = "";
            bool control = true;

            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                if (one.Contains(word[0])) temp = one;
                else if (two.Contains(word[0])) temp = two;
                else temp = three;
                for (int j = 0; j < word.Length; j++)
                {
                    if (!temp.Contains(word[j])) { control = false; break; }
                    else control = true;
                } 
                if(control!=false)
                    list.Add(words[i]);
            }
            string[] result = list.ToArray();
            return result;
        }
    }
}
