namespace Graph;

public class ConnectedComponentCount
{
    public int Solve(Dictionary<int, List<int>> adj)
    {
        HashSet<int> visited = new HashSet<int>();
        int count = 0;
        foreach (int source in adj.Keys)
        {
            if (!visited.Contains(source))
            {
                traverse(adj, source, visited);
                count++;
            }
        }

        return count;
    }

    private void traverse(Dictionary<int, List<int>> adj, int source, HashSet<int> visited)
    {
        if (visited.Contains(source))
        {
            return;
        }

        visited.Add(source);
        foreach (int neighbor in adj[source])
        {
            traverse(adj, neighbor, visited);
        }
    }

    public Dictionary<int, List<int>> BuildAdjancey(List<int[]> nodes)
    {
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
        foreach (int[] pair in nodes)
        {
            if (!adj.ContainsKey(pair[0]))
            {
                adj[pair[0]] = new List<int>();
            }

            if (pair.Length > 1)
            {
                if (!adj.ContainsKey(pair[1]))
                {
                    adj[pair[1]] = new List<int>();
                }

                adj[pair[0]].Add(pair[1]);
                adj[pair[1]].Add(pair[0]);
            }
        }

        return adj;
    }
}