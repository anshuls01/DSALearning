using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    internal class BestSum
    {
        public List<int> find(int target, int[] nums, Dictionary<int, List<int>> memo)
        {
            if (memo.ContainsKey(target))
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
            List<int> best = null;
            foreach (int x in nums)
            {
                int reminder = target - x;
                List<int> current = find(reminder, nums, memo);
                if(current!=null)
                {
                    List<int> currentCombination = new List<int>(current);
                    currentCombination.Add(x);
                    if (best == null || best.Count > currentCombination.Count)
                    {
                        best = currentCombination;
                    }
                }
            }
            memo[target] = best;
            return memo[target];
        }
    }
}
