using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    internal class PartitionEqualSubSetSum
    {
        public bool CanPartition(int[] nums)
        {
            int sum = nums.Sum();
            if (sum % 2 != 0)
            {
                return false;
            }
            int target = sum / 2;

            //find(target, nums, 0, new Dictionary<string, bool>());
            return find(target, nums, 0, new Dictionary<string, bool>());
        }
        private bool find(int target, int[] nums, int index, Dictionary<string, bool> memo)
        {
            string key = $"{target}_{index}";
            if (memo.ContainsKey(key))
            {
                return memo[key];
            }

            if (target == 0) { return true; }
            if (target < 0 || index >= nums.Length) { return false; }

            memo[key] = find(target - nums[index], nums, index + 1, memo) || find(target, nums, index + 1, memo);

            return memo[key];
        }

    }
}
