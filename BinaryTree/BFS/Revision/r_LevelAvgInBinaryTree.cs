using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.BFS.Revision
{
    internal class r_LevelAvgInBinaryTree
    {
        public void print(TreeNode root)
        {

            List<decimal> result = traversal(root);


            Console.WriteLine(string.Join(",", result));


        }
        private List<decimal> traversal(TreeNode root)
        {
            List<decimal> result = new List<decimal>();

            if (root == null)
            {
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                int sum = 0;
                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    sum += current.Val;
                    if (current.Left != null)
                    {
                        queue.Enqueue(current.Left);
                    }
                    if (current.Right != null)
                    {
                        queue.Enqueue(current.Right);
                    }
                }
                result.Add((decimal)sum / size);
            }
            return result;
        }
    
    public TreeNode BuildTree()
    {
        TreeNode root = new TreeNode(1);
        root.Left = new TreeNode(2);
        root.Right = new TreeNode(3);
        root.Left.Left = new TreeNode(4);
        root.Left.Right = new TreeNode(5);
        root.Right.Right = new TreeNode(5);
        root.Right.Left = new TreeNode(6);
        root.Right.Right = new TreeNode(7);

        return root;
    }
}
}
