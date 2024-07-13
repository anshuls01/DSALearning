namespace BinaryTree.DFS;

public class SumOfPathNumbers
{
    // without returning all path details
    public void Print_v1(TreeNode root)
    {
        if (root == null)
        {
            Console.WriteLine(0);
            return;
        }
        
        Console.WriteLine(getAllPathNumberSum(root,0));
    }

    private int getAllPathNumberSum(TreeNode root, int pathSum)
    {
        if (root == null)
        {
            return 0;
        }

        pathSum = pathSum * 10 + root.Val;
        if (root.Left == null && root.Right == null)
        {
            return pathSum;
        }

        return getAllPathNumberSum(root.Left, pathSum) +
               getAllPathNumberSum(root.Right, pathSum);
    }

    public void Print(TreeNode root)
    {
        if (root == null)
        {
            Console.WriteLine(0);
            return;
        }
        // one is get all the path and convert to number and do sum
        // lets do it
        List<List<int>> allpaths = new List<List<int>>();
        List<int> currentpath = new List<int>();
        getAllPaths(root, allpaths, currentpath);
        int sum = 0;
        foreach (List<int> path in allpaths)
        {
            int number = 0;
            foreach (int n in path)
            {
                number = number * 10 + n;
            }

            sum += number;
        }
        
        Console.WriteLine(sum);
    }

    private void getAllPaths(TreeNode root, List<List<int>> allpaths, List<int> currentpath)
    {
        if (root == null)
        {
            return;
        }
        currentpath.Add(root.Val);
        if (root.Left == null && root.Right == null)
        {
            allpaths.Add(new List<int>(currentpath));
        }
        
        getAllPaths(root.Left,allpaths,currentpath);
        getAllPaths(root.Right,allpaths,currentpath);
        
        currentpath.RemoveAt(currentpath.Count-1);
    }

    public TreeNode BuildTree()
    {
        TreeNode root = new TreeNode(1);
        root.Left = new TreeNode(7);
        root.Right = new TreeNode(9);
        root.Right.Left = new TreeNode(2);
        root.Right.Right = new TreeNode(9);
        return root;
    }
}