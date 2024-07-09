namespace BinaryTree.BFS;

public class MaxNodeValueAtEachLevel
{
    public void print(TreeNode root)
    {
        List<int> result = Solution(root);

        if (result.Count > 0)
        {
            Console.WriteLine(string.Join(",",result));
        }
    }

    private List<int> Solution(TreeNode root)
    {
        if (root == null)
        {
            return new List<int>();
        }

        List<int> result = new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int size = queue.Count;
            int maxValue = int.MinValue;
            for (int i = 0; i < size; i++)
            {
                TreeNode current = queue.Dequeue();
                maxValue = Math.Max(maxValue, current.Val);
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
            
            result.Add(maxValue);
        }

        return result;
    }

    public TreeNode BuildTree()
    {
        TreeNode root = new TreeNode(12);
        root.Left = new TreeNode(7);
        root.Right = new TreeNode(1);
        root.Left.Left = new TreeNode(9);
        root.Left.Right = new TreeNode(2);
        root.Right.Left = new TreeNode(10);
        root.Right.Right = new TreeNode(5);

        return root;
    }
}