using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TopologicalSort
{
    internal class TopologicalSortTemplate
    {
        public void Print(Dictionary<int, List<int>> adj)
        { 
            Stack<int> stack = new Stack<int>();
            HashSet<int> visited = new HashSet<int>();

            foreach (int key in adj.Keys)
            {
                TopologicalSortUtil(key, stack, visited, adj);
            }
            //print the topological sort values
            while (stack.Count > 0)
            { 
                Console.WriteLine(stack.Pop());
            }
        }

        private void TopologicalSortUtil(int key, Stack<int> stack, HashSet<int> visited, Dictionary<int, List<int>> adj)
        {
            if (visited.Contains(key))
            {
                return;
            }
            visited.Add(key);
            foreach (int neighbor in adj[key])
            {
                TopologicalSortUtil(neighbor, stack, visited, adj);
            }
            stack.Push(key);
        }

        public Dictionary<int, List<int>> CreateAdjency(int[][] edges)
        {
            Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
            foreach (int[] edge in edges)
            {
                if (!adj.ContainsKey(edge[0]))
                {
                    adj[edge[0]] = new List<int>();
                }
                if (!adj.ContainsKey(edge[1]))
                {
                    adj[edge[1]] = new List<int>();
                }
                adj[edge[0]].Add(edge[1]);
            }
            return adj;
        }
    }
}
