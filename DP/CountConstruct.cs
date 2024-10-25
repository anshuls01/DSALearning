using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    internal class CountConstruct
    {
        public int find(string target, string[] bank, Dictionary<string, int> memo)
        {
            if (memo.ContainsKey(target))
            { 
                return memo[target];
            }
            if (target.Length == 0)
            {
                return 1;
            }

            int count = 0;
            foreach (string word in bank)
            {
                if (target.IndexOf(word) == 0)
                { 
                    count += find(target.Substring(word.Length),bank, memo);
                }
            }

            memo[target] = count;
            return count;
        }
    }
}
