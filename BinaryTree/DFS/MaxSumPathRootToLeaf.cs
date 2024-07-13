namespace BinaryTree.DFS;

public class MaxSumPathRootToLeaf
{
    public void Print(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        List<List<int>> allPaths = new List<List<int>>();
        List<int> currentPath = new List<int>();
        MaxSumPath(root, allPaths, currentPath);

        foreach (List<int> path in allPaths)
        {
            Console.WriteLine(string.Join(",", path));
        }
    }


    private void MaxSumPath(TreeNode root, List<List<int>> allPaths, List<int> currentPath)
    {
        if (root == null)
        {
            return;
        }

        currentPath.Add(root.Val);
        if (root.Left == null && root.Right == null)
        {
            int currentPathSum = currentPath.Sum();
            int lastPathSum = 0;
            if (allPaths.Count > 0)
            {
                lastPathSum = allPaths[allPaths.Count - 1].Sum();
            }

            if (lastPathSum < currentPathSum)
            {
                if (allPaths.Count > 0)
                    allPaths.RemoveAt(allPaths.Count - 1);
                allPaths.Add(new List<int>(currentPath));
            }
        }
        else
        {
            MaxSumPath(root.Left, allPaths, currentPath);
            MaxSumPath(root.Right, allPaths, currentPath);
        }


        currentPath.RemoveAt(currentPath.Count - 1);
    }

    public TreeNode BuildTree()
    {
        TreeNode root = new TreeNode(12);
        root.Left = new TreeNode(7);
        root.Right = new TreeNode(1);
        root.Left.Left = new TreeNode(4);
        root.Right.Left = new TreeNode(10);
        root.Right.Right = new TreeNode(5);
        return root;
    }
}