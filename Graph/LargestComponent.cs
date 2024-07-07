namespace Graph;

public class LargestComponent
{
    // print length of largest component
    public int Solve(Dictionary<int, List<int>> adj)
    {
        HashSet<int> visited = new HashSet<int>();
        int maxCount = int.MinValue;

        foreach (int source in adj.Keys)
        {
            if (!visited.Contains(source))
            {
                int componentCount = 0;
                int count = traverse(adj, source, visited);
                maxCount = Math.Max(count, maxCount);
            }
        }

        return maxCount;
    }

    private int traverse(Dictionary<int, List<int>> adj, int source, HashSet<int> visited)
    {
        if (visited.Contains(source))
        {
            return 0;
        }

        visited.Add(source);
        int size = 1; 
        foreach (int neighbor in adj[source])
        {
            
            size+=traverse(adj, neighbor, visited);
        }

        return size;
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