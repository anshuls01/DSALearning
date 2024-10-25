using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class MaximumPointsYouCanObtainfromCards
    {
        /// <summary>
        /// this is a sliding window question to find min sum window
        /// then subtract total - minsum to get the max sum or selected cards
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int find(int[] nums, int k)
        {
            if (nums == null) { return 0; }
            if (nums.Length <= k)
            {
                return nums.Sum();
            }

            int start = 0;
            int end = 0;
            int sum = 0;
            int minSum = int.MaxValue;
            int ws = nums.Length - k;
            while (end<nums.Length)
            {
                sum+= nums[end];
                if (end - start + 1 == ws)
                { 
                    minSum = Math.Min(minSum,sum);
                    sum -= nums[start];
                    start++;
                }
                end++;
            }

            return nums.Sum()-minSum;
        }
        //public int find(int[] nums, int k)
        //{
        //    if (nums == null) { return 0; }
        //    if (nums.Length <= k)
        //    {
        //        return nums.Sum();
        //    }

        //    int start = 0;
        //    int end = nums.Length - 1;
        //    int sum = 0;
        //    while (k > 0)
        //    {
        //        if (nums[start] > nums[end])
        //        {
        //            sum += nums[start];
        //            start++;
        //        }
        //        else
        //        {
        //            sum += nums[end];
        //            end--;

        //        }
        //        k--;
        //    }

        //    return sum;
        //}
    }
}
