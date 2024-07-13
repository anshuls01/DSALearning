using System.Xml.Schema;

namespace BinaryTree.DFS;

public class AllPathForASum
{
    public void Print_v1(TreeNode root, int sum)
    {
        if (root == null)
        {
            return;
        }

        List<List<int>> result = new List<List<int>>();
        List<int> currentPath = new List<int>();
        findPaths_v1(root, sum, result, currentPath);
        foreach (List<int> path in result)
        {
            Console.WriteLine(string.Join(",", path));
        }
    }

    private void findPaths_v1(TreeNode root, int sum, List<List<int>> result, List<int> currentPath)
    {
        if (root == null)
        {
            return;
        }

        currentPath.Add(root.Val);
        if (root.Left == null && root.Right == null && root.Val == sum)
        {
            result.Add(new List<int>(currentPath));
        }
        else
        {
            findPaths_v1(root.Left, sum - root.Val, result, currentPath);
            findPaths_v1(root.Right, sum - root.Val, result, currentPath);
        }

        currentPath.RemoveAt(currentPath.Count - 1);
    }

    public void Print(TreeNode root, int sum)
    {
        if (root == null)
        {
            return;
        }

        List<List<int>> result = findPaths(root, sum);
        foreach (List<int> path in result)
        {
            Console.WriteLine(string.Join(",", path));
        }
    }

    private List<List<int>> findPaths(TreeNode root, int sum)
    {
        if (root == null)
        {
            return null;
        }

        if (root.Left == null && root.Right == null && root.Val == sum) //leaf node
        {
            return new List<List<int>> { new List<int>() { root.Val } };
        }

        List<List<int>> allPaths = new List<List<int>>();

        List<List<int>> leftPath = findPaths(root.Left, sum - root.Val);
        List<List<int>> rightPath = findPaths(root.Right, sum - root.Val);
        if (leftPath != null)
        {
            foreach (List<int> path in leftPath)
            {
                path.Add(root.Val);
            }

            allPaths.AddRange(leftPath);
        }

        if (rightPath != null)
        {
            foreach (List<int> path in rightPath)
            {
                path.Add(root.Val);
            }

            allPaths.AddRange(rightPath);
        }


        return allPaths;
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