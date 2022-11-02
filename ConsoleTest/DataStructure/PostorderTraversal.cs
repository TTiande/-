using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{//145.二叉树的后序遍历
    class PostorderTraversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            //后序遍历：左右中。算法：递归。
            IList<int> temp = new List<int>();
            if (root == null) return temp;
            caculate(root, ref temp);
            return temp;
        }
        public void caculate(TreeNode root, ref IList<int> temp)
        {
            if (root != null)
            {
                if (root.left != null) caculate(root.left, ref temp);
                if (root.right != null) caculate(root.right, ref temp);
                temp.Add(root.val);
            }
        }
    }
}
