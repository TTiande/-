using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure.Set;

namespace DataStructure
{
    class Program
    {

        static void Main(string[] args)
        {
            TreeNode a = new TreeNode(1);
            a.right = new TreeNode(2);
            a.right.left = new TreeNode(3);
            IList<int> res=InorderTraversal(a);
            foreach (var i in res)
            {
                Console.Write(i);
            }
            
            Console.Read();
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
            public static IList<int> InorderTraversal(TreeNode root)
            {  
                IList<int> resu=new List<int>();
                if (root == null) return resu;
                //迭代遍历
                if (root.left != null)
                {
                    IList<int> temp = new List<int>();
                    temp=InorderTraversal(root.left);
                    foreach (var i in temp) 
                    {
                        resu.Add(i);
                    }
                }
                resu.Add(root.val);
                if (root.right != null)
                {
                    IList<int> temp = new List<int>();
                    temp = InorderTraversal(root.right);
                    foreach (var i in temp)
                    {
                        resu.Add(i);
                    }
                }
                return resu;

            }
        

    }
}
