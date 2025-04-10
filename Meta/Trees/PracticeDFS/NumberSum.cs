using System;
using System.Security.Cryptography.X509Certificates;

namespace Meta.Trees.PracticeDFS;

public class NumberSum
{
      public TreeNode PrepreTree()
    {
        TreeNode node = new TreeNode(1);
        node.Left = new TreeNode(7);
        node.Right = new TreeNode(9);
        node.Right.Left = new TreeNode(2);
        node.Right.Right = new TreeNode(9);
        return node;
    }

        public int result = 0;

    public void solve(TreeNode root)
    {
        if(root==null)
        {
            Console.WriteLine(result);
        }
        find(root,0);
        Console.WriteLine(result);
    }

    private void find(TreeNode root, int cs)
    {
        if(root==null)
        {
            return;
        }
        cs= cs*10 +root.Val;
        if(root.Left==null && root.Right==null)
        {
            result+=cs;
        }
        else
        {
            find(root.Left, cs);
            find( root.Right,cs);
        }
        cs = cs/10;
    }
}
