using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class MinimumDifferenceBetweenLargestandSmallestValueInThreeMoves
    {
        public int find(int[] nums)
        {
            if (nums == null || nums.Length <= 4)
            {
                return 0;
            }
            Array.Sort(nums);//nlogn

            //if (nums[0] == nums[nums.Length - 1])
            //{
            //    return 0;
            //}
            /*
             * 1,5,6,14,15
             * 1,5,5,5,5  -> [n-4]-[0]
             * 14,14,14,14,15 -> [n-1]-[3]
             * 6,6,6,14,14 -> [n-2] - [2]
             * 5,5,6,6,6 -> [n-3]-[1]
             */
            int n = nums.Length;
            return Math.Min(Math.Min(nums[n - 4] - nums[0], nums[n - 1] - nums[3]), Math.Min(nums[n - 2] - nums[2],nums[n - 3] - nums[1]));
        }
    }
}
