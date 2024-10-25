using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    internal class AllSum
    {
        public List<List<int>> find(int target, int[] nums, Dictionary<int, List<List<int>>> memo)
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
                return new List<List<int>>() { new List<int>()};
            }

            List<List<int>> allPath = new List<List<int>>();
            foreach (int n in nums)
            { 
                int reminder = target - n;
                List<List<int>> reminderCombinations = find(reminder, nums, memo);
                if (reminderCombinations != null)
                {
                    foreach (List<int> reminderCombination in reminderCombinations)
                    {
                        List<int> current = new List<int>(reminderCombination);
                        current.Add(n);
                        allPath.Add(current);
                    }
                }

            }
            memo[target] = allPath;
            return memo[target];
        }
    }
}
