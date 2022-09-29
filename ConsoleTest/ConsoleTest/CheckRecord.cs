using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class CheckRecord
    {//学生出勤记录I
        public bool checkRecord(string s)
        {
            s = s.Replace('L', 'B').Replace('P', 'C');
            int[] temp = new int[3];
            foreach (var i in s) temp[i - 'A']++;
            if (temp[0] < 2 && !s.Contains("LLL")) return true;
            return false;
        }
    }
}
