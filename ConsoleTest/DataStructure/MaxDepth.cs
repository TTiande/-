using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    class MaxDepth
    {
        public int maxDepth(TreeNode root)
        {//104.二叉树的最大深度
            //列表记录每层节点是最好的，BFS
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
