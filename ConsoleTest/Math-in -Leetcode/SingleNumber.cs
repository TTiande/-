using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_in__Leetcode
{//136.只出现一次的数字。
    class SingleNumber
    {
        public int singleNumber(int[] nums)
        {
            //复习位运算。位运算实质的数值运算，得到的结果要么0要么1，相同为0.不同为1。
            //位移运算是在二进制数上面进行的，很少会用到。
            //不使用额外空间的话，只能用数组索引进行判断。notes:注重
            Array.Sort(nums);
            int i = 0;
            while (i < nums.Length)
            {
                int j = i + 1;
                if (i == nums.Length - 1) return nums[i];
                if ((nums[i] ^ nums[j]) >0) return nums[i];
                i += 2;
            }
            return -1;
        }
    }
}
