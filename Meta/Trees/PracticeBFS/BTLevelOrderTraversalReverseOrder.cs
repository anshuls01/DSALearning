using System;
using System.Diagnostics.Tracing;

namespace Meta.Trees.PracticeBFS;

public class BTLevelOrderTraversalReverseOrder
{

    public List<List<int>> solve(TreeNode root)
    {
        var result = new List<List<int>>();

        if(root==null)
        {
            return result;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count>0)
        {
            List<int> levelNode = new List<int>();

            for(int i = 0;i<queue.Count;i++)
            {
                TreeNode current = queue.Dequeue();

                levelNode.Add(current.Val);
               
                if(current.Left!=null)
                {
                    queue.Enqueue(current.Left);
                }
                if(current.Right!=null)
                {
                    queue.Enqueue(current.Right);
                }

            }

            result.Insert(0, levelNode);
        }
        return result;
    }
}
