using System;

namespace Meta.Trees.PracticeBFS;

public class ConnectOrderLevelSiblings
{
  public class TreeNode {
  public int Val;
  public TreeNode Left;
  public TreeNode Right;
  public TreeNode Next;

  public TreeNode(int x) {
    Val = x;
    Left = Right = Next = null;
  }
}

    public TreeNode solve(TreeNode root)
    {
        if(root==null)
        {
            return root;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count>0)
        {
            int size = queue.Count;
            TreeNode prev = null;
            for(int i =0;i<size;i++)
            {
           
                TreeNode current = queue.Dequeue();
                if(prev!=null)
                {
                    prev.Next = current;
                }
                prev = current;
                if(current.Left!=null)
                {
                    queue.Enqueue(current.Left);
                }
                if(current.Right!=null)
                {
                    queue.Enqueue(current.Right);
                }
            }
        }
        return root;
    }

}
