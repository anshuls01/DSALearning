using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.revision
{
    internal class LargestComponentSize
    {
        public int find(Dictionary<int, List<int>> adj)
        {
            int maxLength = 0;
            if (adj == null || adj.Count == 0)
            {
                return maxLength;
            }

            HashSet<int> visited = new HashSet<int>();
            foreach (int node in adj.Keys) {
                int currentLength = dfs(node, adj, visited);
                maxLength = Math.Max(maxLength, currentLength);
            }
            return maxLength;
        }

        private int dfs(int node, Dictionary<int, List<int>> adj, HashSet<int> visited)
        {
            if (visited.Contains(node))
            {
                return 0;
            }
            visited.Add(node);
            int length = 1;
            foreach (int neighbor in adj[node])
            { 
                length += dfs(neighbor, adj, visited);
            }

            return length;
        }
    }
}
