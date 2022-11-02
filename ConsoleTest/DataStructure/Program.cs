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
            TreeNode root = new TreeNode(1);
            root.left =new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = null;
            root.right.right = null;
            Solution a = new Solution();
            
            Console.Write(a.MinDepth(root));
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

        public class Solution
        {
            public int MinDepth(TreeNode root)
            {
                int level = 0;
                if (root == null) return 0;
                Stack<TreeNode> temp1 = new Stack<TreeNode>();
                Stack<TreeNode> temp2 = new Stack<TreeNode>();
                temp1.Push(root);
                level++;
                while (temp1 != null)
                {

                    for (var i = 0; i < temp1.Count; )
                    {
                        TreeNode temp = temp1.Pop();
                        if (temp.left == null && temp.right == null)
                            return level;
                        if (temp.left != null) temp2.Push(temp.left);
                        if (temp.right != null) temp2.Push(temp.right);
                    }
                    level++;
                    temp1 = new Stack<TreeNode>(temp2.ToArray());
                    temp2.Clear();
                }
                return level;
            }
        }
        
        

    }
}
