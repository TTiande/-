using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class ConvertToTitle
    {
        public string convertToTitle(int columnNumber)
        {
            StringBuilder temp = new StringBuilder();
            while (columnNumber > 0)
            {
                temp.Append(columnNumber % 26);
                columnNumber = columnNumber / 26;
            }
            string ac = null;
            for (int i = 0; i < temp.Length; i++)
            {
                ac += numToColumn(int.Parse(temp[i].ToString()));
            }
            return ac;
        }
        public string numToColumn(int a)
        {
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return str[a].ToString();
        }
    }
}
