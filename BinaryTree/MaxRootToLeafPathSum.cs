namespace BinaryTree;

public class MaxRootToLeafPathSum
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
        Node c = new Node(3);
        Node d = new Node(4);
        Node e = new Node(2);
        Node f = new Node(1);

        a.left = b;
        a.right = c;
        b.left = d;
        b.right = e;
        c.right = f;

        return a;
    }

    public int MaxPathSum_DFS_Recursive(Node root)
    {
        if (root == null)
        {
            return int.MinValue;
        }

        if (root.left == null && root.right == null)
        {
            return root.value;
        }

        int leftSum = MaxPathSum_DFS_Recursive(root.left); // gives left node value
        int rightSum = MaxPathSum_DFS_Recursive(root.right); // gives right node vaue

        return root.value + Math.Max(leftSum, rightSum); //max from left or right + current root value 
    }
}