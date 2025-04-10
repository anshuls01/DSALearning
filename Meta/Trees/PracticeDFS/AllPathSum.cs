using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Meta.Trees.PracticeDFS;

public class AllPathSum
{
      public TreeNode PrepreTree()
    {
        TreeNode node = new TreeNode(1);
        node.Left = new TreeNode(7);
        node.Right = new TreeNode(9);
        node.Left.Left = new TreeNode(4);
        node.Left.Right = new TreeNode(5);
        node.Right.Left = new TreeNode(2);
        node.Right.Right = new TreeNode(7);
        return node;
    }


    public void Solve(TreeNode root, int sum)
    {
        List<List<int>> allPath = new List<List<int>>();
        List<int> cp = new List<int>();
        find(root,allPath,cp,sum);
        foreach(List<int> nodes in allPath)
        {
            Console.WriteLine(string.Join(",",nodes));
        }
    }

    private void find(TreeNode root, List<List<int>> allPath, List<int> cp, int sum)
    {
        if(root==null)
        {
            return;
        }
        cp.Add(root.Val);
        if(root.Left==null && root.Right==null)
        {
            if(sum==root.Val)
            {
                allPath.Add(new List<int>(cp));
            }
            cp.RemoveAt(cp.Count-1);
            return;
        }
        sum = sum-root.Val;
        find(root.Left,allPath,cp,sum);
        find(root.Right,allPath,cp,sum);
        cp.RemoveAt(cp.Count-1);
    }
}
