using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    internal class SubSetSum
    {
        public bool find_recurssion(int[] nums, int target, int index = 0)
        {
            if (target == 0)
            {
                return true;
            }

            if (target < 0 || index == nums.Length)
            {
                return false;
            }

            return find_recurssion(nums, target - nums[index], index + 1) || find_recurssion(nums, target, index + 1);
        }


        public bool find_recurssion_memo(int[] nums, int target, Dictionary<string, bool> memo, int index = 0)
        {
            string key = $"{target}_{index}";
            if (memo.ContainsKey(key))
            {
                return memo[key];
            }
            if (target == 0)
            {
                return true;
            }

            if (target < 0 || index == nums.Length)
            {
                return false;
            }

            memo[key] = find_recurssion_memo(nums, target - nums[index], memo, index + 1) || find_recurssion_memo(nums, target, memo, index + 1);
            return memo[key];
        }

        public bool find_Tabulation(int[] nums, int target)
        {
            bool[,] matrix = new bool[ nums.Length + 1, target + 1];
            intializeMatrix(matrix, nums.Length + 1, target + 1);
            for (int i = 1; i <= nums.Length; i++)
            {
                for (int j = 1; j <= target; j++)
                {
                    if (nums[i - 1]<=j)
                    {
                        matrix[i, j] = matrix[i - 1,j - nums[i - 1]] || matrix[i - 1,j];
                    }
                    else
                    {
                        matrix[i, j] = matrix[i-1, j];
                    }
                }
            }
            
            return matrix[ nums.Length, target];
        }

        private void intializeMatrix(bool[,] matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == 0 )
                    {
                        matrix[i,j] = true; 
                    }
                    if (i != 0 && j == 0)
                    { 
                        matrix[i,j] = false;
                    }
                }
            }
        }
    }
}
