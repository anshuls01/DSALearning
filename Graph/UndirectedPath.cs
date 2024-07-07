namespace Graph;

public class UndirectedPath
{
    public bool ValidatePathBetweenSourceAndDestination(Dictionary<char, List<char>> adj, char source, char target)
    {
        return Exists(adj, source, target, new HashSet<char>());
    }

    private bool Exists(Dictionary<char, List<char>> adj, char source, char target, HashSet<char> visited)
    {
        
        if (adj.ContainsKey(source) && source == target)
        {
            return true;
        }

        if (visited.Contains(source))
        {
            return false;
        }

        visited.Add(source);
        foreach (char neighbor in adj[source])
        {
            bool result = Exists(adj, neighbor, target, visited);
            if (result)
            {
                return true;
            }
        }
        
        return false;
    }

    public Dictionary<char, List<char>> BuildAdjancey(List<char[]> nodes)
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