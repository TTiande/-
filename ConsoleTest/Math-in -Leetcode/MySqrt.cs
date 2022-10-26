using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_in__Leetcode
{
    class MySqrt
    {//69.X的平方根（不能使用内置函数）
        public int mySqrt(int x)
        {
             //二分查找。从小到大找，因为后面数字太大了。
        try{
            //根据奇偶数判断开始值。
            if(x==0)return 0;
            if(x%2==0){
                int i=2;
                int pre=i;
                while(i<=x){
                    if(i*i==x)return i;
                    else{
                        if(i*i>x)//找到二分查找对应的开始结束位置。
                        {
                            int start=pre;
                            int end=i;
                            int mid=(start+end)/2;
                            while(start<end){
                                if(mid*mid<==x)return mid;
                                else{
                                    if(mid*mid>x){
                                        end=mid;
                                        mid=(start+end)/2;
                                    }
                                    else{
                                        start=mid;
                                        mid=(start+end)/2;
                                    }
                                }
                            }
                            return start;
                        }
                        pre=i;
                        i=i*i;
                    }
                }
            }
            else{
                int i=1;
                int pre=i;
                while(i<=x){
                    
                }
            }
        }
        catch{
            Console.Write("出错了！");
        }
#region BF算法,超出时间限制。
            //try
            //{
            //    int i = 0;
            //    while (i <= x)
            //    {
            //        if (i * i == x) return i;
            //        else
            //        {
            //            if (i * i > x) return --i;
            //            i++;
            //        }
            //    }
            //}
            //catch (Exception ee)
            //{
            //    throw ee;
            //}
            //return -1;
#endregion
            
        }
    }
}
