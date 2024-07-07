namespace Graph;

public class ShortestPath
{
    public int Solve_BFS(Dictionary<char, List<char>> adj, char source, char target)
    {
        if (adj == null || adj.Count == 0)
        {
            return - 1;
        }

        if (adj.ContainsKey(source) && source == target)
        {
            return 0;
        }

        HashSet<char> visited = new HashSet<char>();

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(new Node(0,source));
        visited.Add(source);
        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            if (current.value == target)
            {
                return current.distance;
            }

            foreach (char neighbor in adj[current.value])
            {
                if (!visited.Contains(neighbor))
                {
                    queue.Enqueue(new Node(current.distance + 1, neighbor));
                    visited.Add(neighbor);
                }
            }
        }

        return -1;
    }

    public class Node
    {
        public char value { get; set; }
        public int distance { get; set; }

        public Node(int distance, char value)
        {
            this.distance = distance;
            this.value = value;
        }
    }

    public Dictionary<char, List<char>> BuildAdjancy(List<char[]> nodes)
    {
        Dictionary<char, List<char>> adj = new Dictionary<char, List<char>>();
        foreach (char[] pair in nodes)
        {
            if (!adj.ContainsKey(pair[0]))
            {
                adj[pair[0]] = new List<char>();
            }
            if (!adj.ContainsKey(pair[1]))
            {
                adj[pair[1]] = new List<char>();
            }

            adj[pair[0]].Add(pair[1]);
            adj[pair[1]].Add(pair[0]);
        }

        return adj;
    }
}