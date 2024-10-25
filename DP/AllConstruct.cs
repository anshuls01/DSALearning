using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    internal class AllConstruct
    {
        public List<List<string>> find(string target, string[] bank, Dictionary<string, List<List<string>>> memo)
        {
            if (memo.ContainsKey(target))
            { 
                return memo[target];
            }
            if (target.Length == 0)
            { 
                return new List<List<string>>() { new List<string>()};
            }

            List<List<string>> allWays = new List<List<string>>();
            foreach (string word in bank) {
                if (target.IndexOf(word) == 0)
                { 
                    List<List<string>> pways = find(target.Substring(word.Length), bank, memo);

                    foreach (List<string> pway in pways)
                    {
                        List<string> way = new List<string>(pway);
                        way.Add(word);
                        allWays.Add(way);
                    }
                }
            }
            memo[target] = allWays;
            return allWays;
        }
    }
}
