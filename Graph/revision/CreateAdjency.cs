using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.revision
{
    internal class CreateAdjency
    {

        public Dictionary<T, List<T>> CreateGraphAdjencyList<T>(T[][] edges, bool isDirected) {
            Dictionary<T,List<T>> adj = new Dictionary<T, List<T>> ();
            foreach (T[] edge in edges)
            {
                addKeyIfNotExist(adj, edge[0]);
                addKeyIfNotExist(adj, edge[1]);

                adj[edge[0]].Add(edge[1]);// adding node
                if (!isDirected)
                {
                    adj[edge[1]].Add(edge[0]);// adding node
                }
            }
            //printAdjency(adj);
            return adj;
        }

        private static void addKeyIfNotExist<T>(Dictionary<T, List<T>> adj, T key)
        {
            if (!adj.ContainsKey(key))
            {
                adj[key] = new List<T>();
            }
        }

        private void printAdjency<T>(Dictionary<T, List<T>> adj)
        {
            foreach (T key in adj.Keys)
            {
                Console.WriteLine($"{key}: {string.Join(",", adj[key])}");
            }
        }
    }
}
