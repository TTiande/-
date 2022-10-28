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
            TreeNode root = new TreeNode(2);
            root.left = root.right=new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.left.left.left = new TreeNode(6);
            root.left.left.right = null;
            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(4);
            root.right.left.left = new TreeNode(8);
            root.right.left.right = new TreeNode(6);
            Console.Write(isSymmetric(root));
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
        public static bool isSymmetric(TreeNode root)
        {
            //思路是：从上往下遍历，如果某一个节点不对称，则false。
            //规则是：上一个对称节点下面的左节点==右节点,即左中右==右中左~需要双指针或者使用队列。
            Stack<int> temp1 = new Stack<int>();
            Stack<int> temp2 = new Stack<int>();
            ergodicL(root.left, ref temp1);
            ergodicR(root.right, ref temp2);
            if (temp1.Count != temp2.Count) return false;
            int temp = 0;
            for (int i = 0; i < temp1.Count; i++)
            {
                if (temp1.Pop() != temp2.Pop())
                    return false;
            }
            return true;
        }
        public static void ergodicL(TreeNode a, ref Stack<int> temp)
        {
            if (a != null)
            {
                if (a.left != null)
                {
                    ergodicL(a.left, ref temp);
                    temp.Push(a.left.val);
                }
                else temp.Push(101);
                temp.Push(a.val);
                if (a.right != null)
                {
                    ergodicL(a.right, ref temp);
                    temp.Push(a.right.val);
                }
                else temp.Push(101);
            }



        }
        public static void ergodicR(TreeNode a, ref Stack<int> temp)
        {
            if (a != null)
            {
                if (a.right != null)
                {
                    ergodicR(a.right, ref temp);
                    temp.Push(a.right.val);
                }
                else temp.Push(101);
                temp.Push(a.val);

                if (a.left != null)
                {
                    ergodicR(a.left, ref temp);
                    temp.Push(a.left.val);
                }
                else temp.Push(101);
            }

        }
        

    }
}
