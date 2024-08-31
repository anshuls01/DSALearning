namespace Graph;

public class MutualFriends
{
    public List<char> findMutualFriends(Dictionary<char, List<char>> adj, char start)
    {
        List<char> result = new List<char>();
        if (adj==null || adj.Count==0 || !adj.Keys.Contains(start))
        {
            return result;
        }

        HashSet<char> visited = new HashSet<char>();
        TraverseGraph(adj, visited, result, start);
        return result;
    }

    private void TraverseGraph(Dictionary<char, List<char>> adj, HashSet<char> visited, List<char> result, char root)
    {
        if (visited.Contains(root))
        {
            return;
        }

        visited.Add(root);

        foreach (char neighbor in adj[root])
        {
            if(!visited.Contains(neighbor))
            {
                result.Add(neighbor);
                TraverseGraph(adj, visited, result, neighbor);
            }
        }
    }

    public Dictionary<char, List<char>> CreateAdjencyList(List<char[]> pairs)
    {
        Dictionary<char, List<char>> adj = new Dictionary<char, List<char>>();
        foreach (char[] pair in pairs)
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