using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{//144.二叉树的前序遍历
    class PreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            //前序遍历：根左右
            IList<int> temp = new List<int>();
            if (root == null) return temp;
            else caculate(root, ref temp);
            return temp;
        }
        public void caculate(TreeNode root, ref IList<int> temp)
        {
            if (root != null) temp.Add(root.val);
            if (root.left != null) caculate(root.left, ref temp);
            if (root.right != null) caculate(root.right, ref temp);
        }
    }
}
