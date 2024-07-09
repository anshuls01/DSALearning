namespace BinaryTree.DFS;

public class AllPathSumForASum_BackTracking
{
    public void Print(TreeNode root, int sum)
    {
        if (root == null)
        {
            return;
        }

        List<List<int>> allPaths = new List<List<int>>();
        List<int> currentPath = new List<int>();
        getAllPaths(root, sum, allPaths, currentPath);

        foreach (List<int> path in allPaths)
        {
            Console.WriteLine(string.Join(",", path));
        }
    }

    private void getAllPaths(TreeNode root, int sum, List<List<int>> allPaths, List<int> currentPath)
    {
        if (root == null)
        {
            return;
        }

        currentPath.Add(root.Val);
        if (root.Val == sum && root.Left == null && root.Right == null)
        {
            //found one path
            allPaths.Add(new List<int>(currentPath));
        }
        else
        {
            getAllPaths(root.Left, sum - root.Val, allPaths, currentPath);
            getAllPaths(root.Right, sum - root.Val, allPaths, currentPath);
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