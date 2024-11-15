using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class ContainerWithMostWater
    {
        // i tried to solve this using Stack, didn't work at all
        // finding max height to left And max height to right, get min of both heights also didn't work
        // two pointer apprach will work, basically need to consider pair with maximum width -> hence left and right pointer make more sense
        public int find(int[] nums)
        {
            int maxWater = 0;
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int height = Math.Min(nums[left], nums[right]);
                int width = right - left;
                maxWater = Math.Max(maxWater, height*width);
                if (nums[left] > nums[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return maxWater;
        }
    }
}
