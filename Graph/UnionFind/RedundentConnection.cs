using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Graph.UnionFind
{
    // Union find is helpful to determine:
    // 1. Relationship
    // 2. If two nodes belong to same set
    // In Genral: Union Find, also known as Disjoint Set Union (DSU), is a data structure that keeps track of a partition of a set into disjoint subsets
    // (meaning no set overlaps with another). 
    // It provides two primary operations: find, which determines which subset a particular element is in,
    // and union, which merges two subsets into a single subset.
    // This pattern is particularly useful for problems where we need to find whether 2 elements belong to the same group or need to solve connectivity-related problems in a graph or tree.

    //this  problem can be solved by DFS -> Cycle detection -> Grey black list
    // i'll do that implementation too
    //this implementation is using the Union Find
    internal class RedundentConnection
    {
        
        public int[] findEdge(int[][] edges)
        {
            
            int[] parent = new int[edges.Length + 1];
            intializeParent(parent);

            foreach (int[] edge in edges) {
                int parentA = findParent(parent, edge[0]);
                int parentB = findParent(parent, edge[1]);
                if (parentA == parentB)
                {
                    return edge;
                }
                union(parent, parentA, parentB);
            }
            return new int[0];
        }

        private void union(int[] parent, int parentA, int parentB)
        {
            parent[parentB] = parentA;
        }

        private void intializeParent(int[] parent)
        {
            for (int i = 0; i < parent.Length; i++)
            { 
                parent[i] = i;
            }
        }

        private int findParent(int[] parent, int node)
        {
            if (parent[node] != node)
            {
                parent[node] = findParent(parent, parent[node]);
            }

            return parent[node];
        }
    }
}
