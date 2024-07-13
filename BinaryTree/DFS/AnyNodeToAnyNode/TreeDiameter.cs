namespace BinaryTree.DFS;

public class TreeDiameter
{
    private int treeDiameter = 0;

    public void findDiameter(TreeNode root)
    {
        CalculateHeight(root);
        Console.WriteLine(treeDiameter);
    }

    // will return max diameter respect to current node
    public int CalculateHeight(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftHeight =  CalculateHeight(root.Left);
        int rightHeight = CalculateHeight(root.Right);

        if (leftHeight != 0 && rightHeight != 0)
        {
            int currentDiameter = leftHeight + rightHeight + 1; //current diameter
            treeDiameter = Math.Max(currentDiameter, treeDiameter);
        }

        return Math.Max(leftHeight, rightHeight) + 1;
    }

    public TreeNode BuildTree()
    {
        TreeNode root = new TreeNode(1);
        root.Left = new TreeNode(2);
        root.Right = new TreeNode(3);
        root.Right.Left = new TreeNode(5);
        root.Right.Right = new TreeNode(6);
        root.Right.Left.Left = new TreeNode(7);
        root.Right.Left.Right = new TreeNode(8);
        root.Right.Left.Right.Right = new TreeNode(10);
        root.Right.Right.Right = new TreeNode(9);
        root.Right.Right.Right.Right = new TreeNode(11);
        return root;
    }
}