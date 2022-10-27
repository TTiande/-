using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    class IsSameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p != null || q != null)
            {
                if (p.val != q.val) return false;
            }
            if (p.left != null || q.left != null)
            {
                res = IsSameTree(p.left, q.left);
            }
            if (res != true) return false;
            if (p.right != null || q.right != null)
            {
                res = IsSameTree(p.right, q.right);
            }
            if (res != true) return false;
            return true;
        }   
    }
}
