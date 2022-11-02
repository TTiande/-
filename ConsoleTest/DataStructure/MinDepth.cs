using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{//111.二叉树的最小深度。
    class MinDepth
    {
        public int minDepth(TreeNode root)
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
