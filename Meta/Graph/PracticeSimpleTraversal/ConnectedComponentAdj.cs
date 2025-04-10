using System;
using System.Data;

namespace Meta.Graph;

public class ConnectedComponentAdj
{
    public int solve(int[][] edges)
    {
        if(edges==null || edges.Length==0)
        {
            return 0;
        }
        var adj = BuildAdjacency(edges);
        HashSet<int> visited = new HashSet<int>();
        int count = 0;
        foreach(int node in adj.Keys)
        {
            if(!visited.Contains(node))
            {
                traverse(adj,node,visited);
                count++;
            }
        }
        return count;
    }

    private void traverse(Dictionary<int,List<int>> adj,int node,HashSet<int> visited)
    {
        if(visited.Contains(node))
        {
            return;
        }
        visited.Add(node);
        foreach(int neigh in adj[node])
        {
            traverse(adj,neigh,visited);
        }
    }
 private Dictionary<int,List<int>> BuildAdjacency(int[][] edges)
    {
        var adj = new Dictionary<int,List<int>> ();
        foreach(int[] edge in edges)
        {
            if(!adj.ContainsKey(edge[0]))
            {
                adj[edge[0]] = new List<int>();
            }
            if(!adj.ContainsKey(edge[1]))
            {
                adj[edge[1]] = new List<int>();
            }

            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }
        return adj;
    }
}
