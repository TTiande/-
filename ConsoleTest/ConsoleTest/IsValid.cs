using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class IsValid
    {
        public bool isValid(string s)
        {
            bool ifCorrect = true;
            bool Error = false;
            if (s.Length != 0 && s.Length % 2 != 0)
            {
                ifCorrect = false;
                return ifCorrect;
            }
            for (int i = 0; i < s.Length; i++)
            {
                s=s.Replace(s[i], SymbolToInt(s[i]));
            }

            for (int i = 0; i < s.Length - 1; )
            {
                switch (s[i])
                {
                    case '1': if (s[i + 1] != '2') { ifCorrect = false; break; } else { break; }
                    case '3': if (s[i + 1] != '4') { ifCorrect = false; break; } else { break; }
                    case '5': if (s[i + 1] != '6') { ifCorrect = false; break; } else { break; }
                    default: return Error;
                }
                i += 2;
            }
            return ifCorrect; 
        }
        public char SymbolToInt(char a)
        {
            switch (a)
            {
                case '(': return '1';
                case ')': return '2';
                case '{': return '3';
                case '}': return '4';
                case '[': return '5';
                case ']': return '6';
                default: return '0';
            }
        }
    }
}
