using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    class IsSymmetric
    {
        public bool isSymmetric(TreeNode root)
        {
            //BFS广度优先算法。或者递归。。。
            return ergodic(root.left, root.right);

        }
        public bool ergodic(TreeNode a, TreeNode b)
        {
            if (a == null && b == null) return true;
            if (a == null && b != null || a != null && b == null) return false;
            if (a.val != b.val) return false;
            return ergodic(a.left, b.right) && ergodic(a.right, b.left);
        }
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
}
