using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.TopologicalSort
{
    internal class PrintTopologyOrder
    {
        public Dictionary<int, List<int>> createAdjency(int[][] edges)
        {
            Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
            foreach (int[] edge in edges)
            {
                foreach (int node in edge)
                    if (!adj.ContainsKey(node))
                    {
                        adj[node] = new List<int>();
                    }
                adj[edge[0]].Add(edge[1]);
            }
            return adj;
        }


        public void print(Dictionary<int, List<int>> adj)
        {
            if (adj == null || adj.Count == 0)
            {
                return;
            }

            Dictionary<int, int> dependency = generateDependencyRelation(adj);

            Queue<int> queue = new Queue<int>();
            foreach (int key in dependency.Keys)
            {
                if (dependency[key] == 0)
                {
                    queue.Enqueue(key); //initial block
                }
            }

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                foreach (int neighbor in adj[current])
                {
                    dependency[neighbor] -= 1;
                    if (dependency[neighbor] == 0)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }

        }

        private Dictionary<int, int> generateDependencyRelation(Dictionary<int, List<int>> adj)
        {
            Dictionary<int, int> dependency = new Dictionary<int, int>();
            foreach (int key in adj.Keys)
            {
                dependency[key] = 0;
            }
            foreach (int key in adj.Keys)
            {
                foreach (int neighbor in adj[key])
                {
                    dependency[neighbor] += 1;
                }
            }
            return dependency;
        }
    }
}
