using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class FindElementInRotatedSortedArray
    {
        public int find(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return - 1;
            }

            if (nums.Length == 1 && nums[0] == target)
            {
                return 0;
            }

            int minIndex = findMinIndex(nums);

            if (nums[minIndex] == target)
            { 
                return minIndex;
            }
            int end = nums.Length - 1;

            if(minIndex==0)
            {
                // array is sorted, do simple binary search
                return findElement(nums, target, 0, end);
            }

            if (minIndex + 1 < nums.Length && nums[minIndex] < target && target<=nums[end])
            { 
                return findElement(nums, target, minIndex+1, end);
            }

            if (minIndex - 1 >= 0 && nums[minIndex-1] > target && nums[0] <= target)
            {
                return findElement(nums, target, 0, minIndex - 1);
            }
            return -1;

        }

        private int findMinIndex(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            int n = nums.Length;
            while (start <= end)
            { 
                int mid = start + (end - start)/2;
                int prev = (mid + n - 1) % n;
                int next = (mid + 1 ) % n;
                if (nums[mid] <= nums[prev] && nums[mid] <= nums[next])
                {
                    return mid;
                }

                if (nums[mid] > nums[start])
                {
                    start = next;
                }
                else
                { 
                    end = prev;
                }
            }
            return 0;
        }

        private int findElement(int[] nums, int target, int start, int end)
        {
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
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

            return -1;
        }
    }
}
