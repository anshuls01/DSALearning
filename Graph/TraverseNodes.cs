namespace Graph;

public class TraverseNodes
{
    public void print(Dictionary<char, List<char>> adj, char source)
    {
        if (adj == null || adj.Count == 0)
        {
            return;
        }

        Stack<char> stack = new Stack<char>();
        stack.Push(source);
        while (stack.Count > 0)
        {
            char current = stack.Pop();
            Console.WriteLine(current);
            foreach (char neighbor in adj[current])
            {
                stack.Push(neighbor);
            }
        }
    }

    public void print_recursive(Dictionary<char, List<char>> adj, char source)
    {
        if (adj == null)
        {
            return;
        }

        Console.WriteLine(source);
        foreach (char neighbor in adj[source]) //explicitly base case
            print_recursive(adj, neighbor);
    }

    public Dictionary<char, List<char>> BuildAdjency()
    {
        Dictionary<char, List<char>> adj = new Dictionary<char, List<char>>();

        adj['a'] = new List<char>();
        adj['a'].Add('c');
        adj['a'].Add('b');
        adj['b'] = new List<char>();
        adj['b'].Add('d');
        adj['c'] = new List<char>();
        adj['c'].Add('e');
        adj['d'] = new List<char>();
        adj['d'].Add('f');
        adj['e'] = new List<char>();
        //    adj['e'].Add('b');
        adj['f'] = new List<char>();
        //  adj['f'].Add('d');

        return adj;
    }
}