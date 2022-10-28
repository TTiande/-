using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    class IsSameTree
    {//100.相同的树。
        bool res = true;
        public bool isSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q != null || p != null && q == null)
                return false;
            if (p != null && q != null)
            {
                if (p.val != q.val) return false;
            }
            if (p == null && q == null)
                return true;
            if (p.left != null || q.left != null)
            {
                res = isSameTree(p.left, q.left);
            }
            if (res != true) return false;
            if (p.right != null || q.right != null)
            {
                res = isSameTree(p.right, q.right);
            }
            if (res != true) return false;
            return true;
        }
        //树节点的构造
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
}
