namespace BinaryTree;

public class TreeSum
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
        Node a = new Node(3);
        Node b = new Node(11);
        Node c = new Node(4);
        Node d = new Node(2);
        Node e = new Node(4);
        Node f = new Node(1);

        a.left = b;
        a.right = c;
        b.left = d;
        b.right = e;
        c.right = f;

        return a;
    }

    public int Sum_DFS_Recursive(Node root)
    {
        if (root == null)
        {
            return 0;//base case
        }

        // hypothesis: Sum_DFS_Recursive(root.left) -> will give left sub tree sum
        // Sum_DFS_Recursive(root.left) -> will give right sub tree sum
        // root value + left sub tree sum + right sub tree sum = tree sum
        return root.value + Sum_DFS_Recursive(root.left) + Sum_DFS_Recursive(root.right);
    }
}