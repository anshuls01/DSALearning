namespace BinaryTree;

public class TreeMInValue
{
    public class Node
    {
        public int value { get; set; }
        public Node? left = null;
        public Node? right = null;

        public Node(int value)
        {
            this.value = value;
        }
    }
    
    public Node BuildTreee()
    {
        Node a = new Node(5);
        Node b = new Node(11);
        Node c = new Node(4);
        Node d = new Node(15);
        Node e = new Node(3);
        Node f = new Node(12);

        a.left = b;
        a.right = c;
        b.left = d;
        b.right = e;
        c.right = f;

        return a;
    }

    public int MinValue_DFS_Recursive(Node root)
    {
        if (root == null)
        {
            return int.MaxValue;
        }

        // hypothesis: Math.Min(
        //                      MinValue_DFS_Recursive(root.left) => value from left sub tree
        //                      MinValue_DFS_Recursive(root.right)=> value from right sun tree
        //                     ) => min value from left and right sub tree
        // Math.Min( root, min from left and right) => give min value of tree
        return Math.Min(root.value, Math.Min(MinValue_DFS_Recursive(root.left), MinValue_DFS_Recursive(root.right)));
    }

    public int MinValue_BFS_Queue(Node root)
    {
        if (root == null)
        {
            return -1;
        }

        int minValue = int.MaxValue;
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            minValue = Math.Min(minValue, current.value);
            if (current.left != null)
            {
                queue.Enqueue(current.left);
            }
            
            if (current.right != null)
            {
                queue.Enqueue(current.right);
            }
        }

        return minValue;
    }
}