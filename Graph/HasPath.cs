namespace Graph;

public class HasPath
{
    public bool exist(Dictionary<char, List<char>> adj, char source, char target)
    {
        if (adj.ContainsKey(source) &&  source == target)
        {
            return true;
        }

        foreach (char neighbor in adj[source])
        {
            bool result = exist(adj, neighbor, target);
            if (result)
            {
                return true;
            }
        }

        return false;
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
        }

        return adj;
    }
}