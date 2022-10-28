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
            TreeNode root = new TreeNode(3);
            root.left =new TreeNode(9);
            root.right = new TreeNode(20);
            root.left.left = null;
            root.left.right = null;
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            Solution a = new Solution();
            
            Console.Write(a.MaxDepth(root));
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
            public int MaxDepth(TreeNode root)
            {
                //列表记录每层节点是最好的，BFS
                int res = 0;
                List<TreeNode> temp1 = new List<TreeNode>();//存储当前层节点
                List<TreeNode> temp2 = new List<TreeNode>();//存储下一层节点
                if (root == null) return res;
                temp1.Add(root);
                res++;
                while (temp1.Count != 0)
                {
                    for (int i = 0; i < temp1.Count; i++)
                    {
                        if (temp1[i].left != null) temp2.Add(temp1[i].left);
                        if (temp1[i].right != null) temp2.Add(temp1[i].right);
                    }
                    if (temp2.Count == 0) return res;
                    temp1 = new List<TreeNode>(temp2.ToArray());
                    temp2.Clear();
                    res++;
                }
                return res;
            }
        }
        
        

    }
}
