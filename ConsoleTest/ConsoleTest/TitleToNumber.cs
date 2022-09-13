using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class TitleToNumber
    {
        public int titleToNumber(string columnTitle)
        {
            int sum = 0, columnTitle_Length = columnTitle.Length;
            for (int i = 0; columnTitle_Length > 0; i++)
            {
                sum += ((char)(columnTitle[columnTitle_Length - 1]) - 64) * (int.Parse)(Math.Pow(26, i).ToString());
                columnTitle_Length--;
            }
            return sum;
        }

    }
}
