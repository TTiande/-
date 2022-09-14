using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class BinaryTreePaths
    {
        //测试数据1235
        Stack<int> stack = new Stack<int>();
        List<string> result = new List<string>();
        StringBuilder re = new StringBuilder();
        public IList<string> binaryTreePaths(TreeNode root)
        {
            string s;
            string[] str = s.Split(' ');
            stack = null;
            result = null;
            recurse(root);
            return result;
        }
        public void recurse(TreeNode root) 
        {
            if (root!= null)
            {
                stack.Push(root.val);
                if (root.left == null & root.right == null)
                {
                    re.Clear();
                    foreach (var i in stack) { re.Insert(0, "->"); re.Insert(0, i); };
                    re.Remove(re.Length-1,1);
                    result.Add(re.ToString());
                    return;
                }
                else {
                    recurse(root.left);
                    recurse(root.right);
                }

            }
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
