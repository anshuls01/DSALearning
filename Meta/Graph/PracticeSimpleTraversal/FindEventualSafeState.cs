using System;
using Meta.Trees.PracticeDFS;

namespace Meta.Graph.PracticeSimpleTraversal;

public class FindEventualSafeState
{
    public List<int> find(int[][] edges, int n)
    {
        List<int> result = new List<int>();
        if(edges==null || edges.Length==0)
        {
            return result;
        }
        int[] visited = new int[n];
        for(int i = 0;i<n;i++)
        {
            visited[i] = 0;
        }

        var adj = BuildAdjency(edges);
        foreach(int node in adj.Keys)
        {
            if(dfs(adj,visited,node))
            {
                result.Add(node);
            }
        }
        result.Sort(); 
        return result;
    }

    private bool dfs(Dictionary<int,List<int>> adj, int[] visited, int node)
    {

        if(visited[node]==-1)
        {
            return true;
        }

        if(visited[node]==1)
        {
            return false;
        }

        visited[node] = 1;
        foreach(int neigh in adj[node])
        {
           if(!dfs(adj,visited,neigh))
           {
             return false;
           }
        }
        visited[node] = -1;
        return true;
    }
    private Dictionary<int,List<int>> BuildAdjency(int[][] edges)
    {
        Dictionary<int,List<int>> adj = new Dictionary<int,List<int>>();

        for(int i = 0;i<edges.Length;i++)
        {
            adj[i] = new List<int>();
        }

        foreach(int[] edge in edges)
        {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }
        return adj;
    }
}
