using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DataStructure.Set
{
    class Class1
    {
        public void Name() 
        {
            List<int> a=new List<int>();
            SortedList<int,string> temp=new SortedList<int,string>();
            temp.Add(3,"I");
            temp.Add(5,"You");
            foreach(var i in temp){
                Console.WriteLine(i);
            }

            //加入一个新元素
            temp.Add(4, "Love");
            foreach (var i in temp)
            {
                Console.WriteLine(i);
            }
        }
    }
}
