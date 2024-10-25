using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class MaximumLengthofSemiDecreasingSubarrays
    {

        public int find(int[] nums)
        {
            int maxLength = 0;
            if (nums == null)
            {
                return maxLength;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums.Length - 1; j > i; j--)
                {
                    if (nums[i] > nums[j])
                    {
                        maxLength = Math.Max(maxLength, j - i + 1);
                        break;
                    }
                }
                if (maxLength == nums.Length)
                {
                    break;
                }
            }
            return maxLength;
        }
        // I didn't read the question properly, doesn't matter if middle element increase their value
        //public int find(int[] nums)
        //{
        //    int maxLength = 0;
        //    if (nums == null)
        //    { 
        //        return maxLength;
        //    }
        //    //i'll use sliding window -> keeping track of  current max
        //    int start = 0;
        //    int end = 0;
        //    int length = 0;
        //    while (end < nums.Length)
        //    {
        //        if (nums[start] > nums[end])
        //        {
        //            length++;
        //            maxLength = Math.Max(maxLength, length);
        //        }
        //        else
        //        {
        //            length = 0;
        //            start = end;
        //        }

        //        end++;
        //    }
        //    return maxLength==0?0:maxLength+1;
        //}
    }
}
