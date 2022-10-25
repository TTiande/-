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
            List<int> a=new List<int>();
            int[] b=new int[]{1,1,2};
            foreach (var i in b)
            {
                if (a.Contains(i))
                    continue;
                else
                    a.Add(i);
            }
            foreach(var i in a){
                Console.WriteLine(i);
            }
            
            Console.Read();
        }
    }
}
