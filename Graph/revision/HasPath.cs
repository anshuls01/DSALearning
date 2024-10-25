using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.revision
{
    internal class HasPath
    {
        public bool find(Dictionary<char, List<char>> adj, char source, char target)
        { 
            if(adj.ContainsKey(source) && source==target)
            {
                return true;
            }
            foreach (char neighbor in adj[source])
            {
                if (find(adj, neighbor, target))
                { 
                    return true;
                }
            }
            return false;
        }

        public bool pathExistInAUndirectedGraph(Dictionary<char, List<char>> adj, char source, char dest)
        {
            HashSet<char> visited = new HashSet<char>();
            return findPath(adj, source, dest, visited);
            
        }

        private bool findPath(Dictionary<char, List<char>> adj, char source, char dest, HashSet<char> visited)
        {
            if (source == dest && adj.ContainsKey(source))
            {
                return true;
            }
            if (visited.Contains(source))
            { 
                return false;
            }

            visited.Add(source);
            foreach (char neighbor in adj[source])
            {
                if (findPath(adj, neighbor, dest, visited))
                { 
                    return true;
                }
            }

            return false;
        }
    }
}
