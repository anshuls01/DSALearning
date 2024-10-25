using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    internal class HowSum
    {
        public List<int> find(int target, int[] nums, Dictionary<int, List<int>> memo)
        {
            if(memo.ContainsKey(target))
            {
                return memo[target];
            }

            if (target < 0)
            {
                return null;
            }
            if (target == 0)
            { 
                return new List<int>();
            }
            foreach (int n in nums)
            {
                int reminder = target - n;
                List<int> current = find(reminder, nums, memo);
                if (current != null)
                {
                    current.Add(n);
                    memo[target] = current;
                    return memo[target];
                }
            }
            memo[target] = null;
            return memo[target];
        }
    }
}
