using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    internal class SubsetSumCountToTargetSum
    {
        public int Count(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            return find(nums, target, 0, new Dictionary<string,int>());
        }

        private int find(int[] nums, int target, int index, Dictionary<string, int> memo)
        {
            string key = $"{target}_{index}";
            if (memo.ContainsKey(key))
            { 
                return memo[key];
            }

            if (target == 0)
            {
                return 1;
            }
            if (target < 0 || index >= nums.Length)
            {
                return 0;
            }

            memo[key] = find(nums, target - nums[index], index + 1, memo) + find(nums, target, index + 1, memo);
            return memo[key];
        }

        public int Count_tabulation(int[] nums, int target)
        {
            int[,] matrix = new int[nums.Length + 1, target + 1];
            for (int i = 0; i <= nums.Length; i++)
            {
                for (int j = 0; j <= target; j++)
                {
                    if (j == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                for (int j = 1; j <= target; j++)
                {
                    if (nums[i - 1]<=j)
                    {
                        matrix[i, j] = matrix[i - 1,j - nums[i - 1]] + matrix[i-1, j];
                    }
                    else
                    {
                        matrix[i, j] = matrix[i-1, j ];
                    }
                }
            }

            return matrix[ nums.Length,target];
        }
    }
}
