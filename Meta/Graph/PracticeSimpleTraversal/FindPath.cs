using System;
using Meta.Trees.PracticeBFS;

namespace Meta.Graph.PracticeSimpleTraversal;

public class FindPath
{
    public bool validPath(int n, int[][] edges, int start, int end) 
    {
        if(edges==null || edges.Length==0)
        {
            return false;
        }
        var adj = BuildAdjacency(edges);
        HashSet<int> visited = new HashSet<int>();
        return traverse(adj,start,end,visited);
    }

    private bool traverse( Dictionary<int,List<int>>  adj,int start,int end,HashSet<int> visited)
    {
            if(adj.ContainsKey(start) && start==end)
            {
                return true;
            }
            
            if(visited.Contains(start))
            {
                return false;
            }
            visited.Add(start);
            foreach(int neigh in adj[start])
            {
                bool result = traverse(adj,neigh,end,visited);
                if(result)
                {
                    return true;
                }
            }
            return false;
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
