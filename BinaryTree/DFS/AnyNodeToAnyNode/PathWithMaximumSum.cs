using System.IO.Enumeration;

namespace BinaryTree.DFS;

public class PathWithMaximumSum
{
    private int maxSum = int.MinValue;

    public void maxPathSumNodetoNode(TreeNode root)
    {
        if (root == null)
        {
            Console.WriteLine(0);
        }

        findMaxPathSum(root);
        Console.WriteLine(maxSum);
        
    }

    private int findMaxPathSum(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftSum = findMaxPathSum(root.Left);
        int rightSum = findMaxPathSum(root.Right);

        leftSum = Math.Max(leftSum, 0);
        rightSum = Math.Max(rightSum, 0);
            int currentSum = leftSum + rightSum + root.Val;
            maxSum = Math.Max(currentSum, maxSum);
        

        return Math.Max(leftSum, rightSum) + root.Val;

    }

    public TreeNode BuildTree()
    {
        //TreeNode root = new TreeNode(-1);
        //root.Left = new TreeNode(-3);
        TreeNode root = new TreeNode(1);
        root.Left = new TreeNode(2);
        root.Right = new TreeNode(3);
        root.Left.Left = new TreeNode(4);
        root.Right.Left = new TreeNode(5);
        root.Right.Right = new TreeNode(6);

        return root;
    }
}