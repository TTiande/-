using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{//112.路径总和
    class HasPathSum
    {
        bool res = false;
        int sum = 0;
        public bool hasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            sum = root.val;
            if (root.left != null) caculate(root.left, targetSum);
            if (root.right != null) caculate(root.right, targetSum);
            if (root.left == null && root.right == null && sum == targetSum) res = true;

            return res;
        }
        public void caculate(TreeNode root, int targetSum)
        {
            sum += root.val;
            if (root.left == null && root.right == null)
            {
                if (sum == targetSum) res = true;
            }
            if (root.left != null) caculate(root.left, targetSum);
            if (root.right != null) caculate(root.right, targetSum);
            sum -= root.val;
        }
    }
}
