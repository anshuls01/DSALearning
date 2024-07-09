namespace BinaryTree.BFS;

public class TreeLevelOrderTraversal
{
    public void print(TreeNode root)
    {
        List<List<int>> result = Solution(root);

        foreach (List<int> nodes in result)
        {
            Console.WriteLine(string.Join(",",nodes));
        }
    }

    private List<List<int>> Solution(TreeNode root)
    {
        if (root == null)
        {
            return new List<List<int>>();
        }

        List<List<int>> result = new List<List<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count>0)
        {
            int size = queue.Count;
            List<int> currentLevel = new List<int>(size);
           for (int i = 0; i < size; i++)
            {
                TreeNode current = queue.Dequeue();
                currentLevel.Add(current.Val);

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
            result.Add(currentLevel);
        }

        return result;
    }

    public TreeNode BuildTree()
    {
        TreeNode root = new TreeNode(12);
        root.Left = new TreeNode(7);
        root.Right = new TreeNode(1);
        root.Left.Left = new TreeNode(9);
        root.Right.Left = new TreeNode(10);
        root.Right.Right = new TreeNode(5);

        return root;
    }
}