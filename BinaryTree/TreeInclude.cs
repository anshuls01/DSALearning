using System.Formats.Asn1;
using System.Reflection;

namespace BinaryTree;

public class TreeInclude
{
    public class Node
    {
        public char value { get; set; }
        public Node? left = null;
        public Node? right = null;

        public Node(char value)
        {
            this.value = value;
        }
    }

    public Node BuildTreee()
    {
        Node a = new Node('a');
        Node b = new Node('b');
        Node c = new Node('c');
        Node d = new Node('d');
        Node e = new Node('e');
        Node f = new Node('f');

        a.left = b;
        a.right = c;
        b.left = d;
        b.right = e;
        c.right = f;

        return a;
    }

    public bool Exist_DFS_Recursive(Node? root, char target)
    {
        if (root == null)
        {
            return false;
        }

        if (root.value == target)
        {
            return true;
        }

        bool leftValue = Exist_DFS_Recursive(root.left, target); //hypothesis: this will search in left sub tree [b, d, e]

        bool rightValue  = Exist_DFS_Recursive(root.right, target); //hypothesis: this will search in right sub tree [c, f]
        

        return rightValue || leftValue; //if any of the value is true return
    }

    public bool Exist_DFS_Stack(Node? root, char target)
    {
        if (root == null)
        {
            return false;
        }

        if (root.value == target)
        {
            return true;
        }

        Stack<Node> stack = new Stack<Node>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            Node current = stack.Pop();
            if (current.value == target)
            {
                return true;
            }

            if (current.left != null)
                stack.Push(current.left);

            if (current.right != null)
                stack.Push(current.right);
        }

        return false;
    }
    
    public bool Exist_BFS_Queue(Node? root, char target)
    {
        if (root == null)
        {
            return false;
        }

        if (root.value == target)
        {
            return true;
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            if (current.value == target)
            {
                return true;
            }

            if (current.left != null)
                queue.Enqueue(current.left);

            if (current.right != null)
                queue.Enqueue(current.right);
        }

        return false;
    }
}