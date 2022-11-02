using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_in__Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleNumber a = new SingleNumber();
            //a.mySqrt(2147395599);
            Console.Write(a.singleNumber(new int[]{2,2,1}));
            Console.Read();
        }
    }
}
