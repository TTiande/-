using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class RomanToInt
    {
        
            public int StringToIn(char n)
            {
                switch (n)
                {
                    case 'I': return 1;
                    case 'V': return 5;
                    case 'X': return 10;
                    case 'L': return 50;
                    case 'C': return 100;
                    case 'D': return 500;
                    case 'M': return 1000;
                    default: return 0;
                }
            }
            public int DoubleToJudge(char a, char b)
            {
                switch (a)
                {
                    case 'I': if (b == 'V' || b == 'X') return -1;
                        else return StringToIn(a);
                    case 'X': if (b == 'L' || b == 'C') return -10;
                        else return StringToIn(a);
                    case 'C': if (b == 'D' || b == 'M') return -100;
                        else return StringToIn(a);
                    default: return StringToIn(a);
                }
            }
            public int romanToInt(string s)
            {
                int max = 3999;
                int min = 1;
                int sum = new int();
                char[] s1 = s.ToCharArray();
                for (int i = 0; i < s1.Length; i++)
                {
                    if ((s1[i] == 'X' || s1[i] == 'I' || s1[i] == 'C') & i < s1.Length - 1)
                    {
                        sum += DoubleToJudge(s1[i], s1[i + 1]);
                    }
                    else
                    {
                        sum += StringToIn(s1[i]);
                    }
                }
                return sum;
            }
        
    }
}
