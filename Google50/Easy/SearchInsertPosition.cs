using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Easy
{
    internal class SearchInsertPosition
    {
        public int findIndex(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            { 
                return 0;
            }

            int start = 0;
            int end = nums.Length - 1;
            while (start < end)
            { 
                int mid = (start + end) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                { 
                    start = mid + 1;
                }

            }
            return start;
        }
    }
}
