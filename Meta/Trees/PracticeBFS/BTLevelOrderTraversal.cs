using System;
using System.Xml.XPath;

namespace Meta.Trees.PracticeBFS;

public class BTLevelOrderTraversal
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
            int i = 0;
            int currentCount = queue.Count;
            List<int> currentLevel = new List<int>();
            while(i<currentCount)
            {
                TreeNode current = queue.Dequeue();
                currentLevel.Add(current.Val);
                if(current.Left!=null)
                {
                    queue.Enqueue(current.Left);
                }
                
                if(current.Right!=null)
                {
                    queue.Enqueue(current.Right);
                }

            }
            result.Add(new List<int>(currentLevel));
        }

        return result;

    }
}
