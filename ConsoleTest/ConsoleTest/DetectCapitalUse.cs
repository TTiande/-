using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class DetectCapitalUse
    {//检测大写字母
        public bool detectCapitalUse(string word)
        {
            //正则表达式

            //普通方法，还可以使用char.isLower等来遍历。
            int word_num = 0;
            foreach (var i in word) word_num += i;
            string temp_Cap = word.ToUpper();
            int temp_Cap_num = 0;
            foreach (var i in temp_Cap) temp_Cap_num += i;
            string temp_Low = word.ToLower();
            int temp_Low_num = 0;
            foreach (var i in temp_Low) temp_Low_num += i;

            //判断。
            if (word_num == temp_Cap_num || word_num == temp_Low_num) return true;
            if (word[0] >= 65 && word[0] <= 90)
                return 32 * (word.Length - 1) + temp_Cap_num == word_num;
            return false;
        }
    }
}
