using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleTest
{
    class ConvertToTitle
    {
        public string convertToTitle(int n)
        {
            string s = "";
            while (n != 0)
            {//每次都减一，是因为不减1做不了26进制的求余，会溢出。
                n--;
                int div = n % 26;
                s = (char)('A' + div) + s;
                n = n / 26;
            }
            return s;

        }
    }
}
