using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.BFS.Revision
{
    internal class r_ReverseLevelOrderTraversal
    {
        public void print(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            List<List<int>> treeLevels = new List<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                List<int> nodes = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    nodes.Add(current.Val);
                    if (current.Left != null)
                    {
                        queue.Enqueue(current.Left);
                    }
                    if (current.Right != null)
                    {
                        queue.Enqueue(current.Right);
                    }
                }
                treeLevels.Insert(0, nodes);
                
            }
            foreach (List<int> treeLevel in treeLevels)
            {
                Console.WriteLine(string.Join(",", treeLevel));
            }
        }

      
    }
}
