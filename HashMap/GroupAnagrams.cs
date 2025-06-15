using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    public class GroupAnagrams
    {
        public void Solve(List<string> tokens)
        {
            if (tokens == null || tokens.Count == 0)
            {
                return;
            }
            List<List<string>> result = new List<List<string>> ();
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>> ();
            foreach (string token in tokens)
            {
                string key = createKey(token);
                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string> ();
                }
                map[key].Add(token);
            }

            foreach (string key in map.Keys)
            {
                Console.WriteLine (string.Join (",", map[key]));
            }
        }

        private string createKey(string token)
        {
            int[] key = new int[26];
            for (int i = 0; i < 26; i++)
            {
                key[i] = 0;
            }
            foreach (char c in token)
            {
                key[c - 'a']++;
            }

            return string.Join ("$", key);
        }
    }
}
