using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.revision
{
    internal class ConnectedComponent
    {
        public int find(Dictionary<int, List<int>> adj)
        {
            int count = 0;
            HashSet<int> visited = new HashSet<int>();
            foreach (int node in adj.Keys)
            {
                if (dfs(adj, node, visited))
                {
                    count++;
                }
            }

            return count;
        }

        private bool dfs(Dictionary<int, List<int>> adj, int node, HashSet<int> visited)
        {
            if (visited.Contains(node))
            {
                return false;
            }

            visited.Add(node);

            foreach (int neighbor in adj[node])
            {
                dfs(adj, neighbor, visited);
              
            }
            return true;
        }
    }
}
