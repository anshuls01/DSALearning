using System;
using System.ComponentModel;
using System.Dynamic;

namespace Meta.Trees.PracticeBFS;

public class MinimumDepthOfBinaryTree
{

    //minimum depth => BFS
    public int solve(TreeNode root)
    {
        int minHeight = 0;
        if(root==null)
        {
            return minHeight;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count>0)
        {
            int size = queue.Count;
            minHeight++;
            for(int i = 0;i<size;i++)
            {
                TreeNode current = queue.Dequeue();
                if(current.Left==null && current.Right==null) //leaf node
                {    
                    return minHeight;       
                }
                if(root.Left!=null)
                {
                    queue.Enqueue(root.Left);
                }
                  if(root.Right!=null)
                {
                    queue.Enqueue(root.Right);
                }
            }
        }

        return minHeight;
    }
}
