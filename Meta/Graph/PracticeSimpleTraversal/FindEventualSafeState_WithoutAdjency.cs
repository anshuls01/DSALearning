using System;

namespace Meta.Graph.PracticeSimpleTraversal;

public class FindEventualSafeState_WithoutAdjency
{
    //Already given graph in terms of Adjency -> why recreate
    public List<int> find(int[][] edges)
    {
        var result = new List<int>();
        if(edges==null || edges.Length==0)
        {
            return result;
        }
        int n = edges.Length;
        int[] visited = new int[n];
        for(int i = 0;i<n;i++)
        {
            visited[i] = 0;
        }

        for(int i = 0;i<n;i++)
        {
            if(dfs(edges,visited,i))
            {
                result.Add(i);
            }
        }

        result.Sort();
        return result;
    }

    private bool dfs(int[][] edges,int[] visited,int node)
    {
        if(visited[node]==-1){return true;}
        if(visited[node]==1){return false;}
        visited[node] = 1;

        foreach(int neigh in edges[node])
        {
            if(!dfs(edges,visited,neigh))
            {
                return false;
            }
        }
        visited[node] = -1;
        return true;
    }
}
