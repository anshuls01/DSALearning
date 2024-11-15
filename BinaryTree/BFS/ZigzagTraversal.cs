namespace BinaryTree.BFS;

public class ZigzagTraversal
{
    public void print(TreeNode root)
    {
        List<List<int>> result = Solution(root);

        foreach (List<int> nodes in result)
        {
            Console.WriteLine(string.Join(",", nodes));
        }

        result = traversal(root);
        foreach (List<int> nodes in result)
        {
            Console.WriteLine(string.Join(",", nodes));
        }
    }
    private List<List<int>> traversal(TreeNode root)
    {
        List<List<int>> result = new List<List<int>>();
        bool direction = false;
        if (root == null)
        {
            return result;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int size = queue.Count;
            List<int> nodes = new List<int>();
            for (int i = 0; i < size; i++)
            {
                TreeNode current = queue.Dequeue();
                if (!direction)
                {
                    nodes.Add(current.Val);
                }
                else
                {
                    nodes.Insert(0, current.Val);
                }
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
            result.Add(nodes);
            direction = !direction;
        }
        return result;
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
        bool leftToRight = true;
        while (queue.Count > 0)
        {
            int size = queue.Count;
            LinkedList<int> currentLevel = new LinkedList<int>();
            for (int i = 0; i < size; i++)
            {
                TreeNode current = queue.Dequeue();
                if (leftToRight)
                {
                    currentLevel.AddLast(current.Val);
                }
                else
                {
                    currentLevel.AddFirst(current.Val);
                }

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            leftToRight = !leftToRight;
            result.Add(new List<int>(currentLevel));
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
        root.Right.Left.Left = new TreeNode(20);
        root.Right.Left.Right = new TreeNode(17);

        return root;
    }
}