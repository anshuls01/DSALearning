using System.ComponentModel.Design;

namespace BinarySearch;

public class FindMinElementInRotatedSortedArray
{
    public int findMin(int[]? nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return -1;
        }

        // because array is sorted -> lets use Binary Search 
        // also assuming number is not repeating
        int start = 0;
        int end = nums.Length - 1;
        int n = nums.Length;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            // if mid is last or first index of array, then has to calculate prev && next to compare with two adjacent values
            int prev = (mid+n-1)%n;
            int next = (mid+1)%n;
            if (nums[mid] <= nums[prev] &&
                nums[mid] <= nums[next]) // if array contains duplicate element -> may be needed to use <=
            {
                return nums[mid];
            }

            //  finding which part of the array is not sorted
            //  start searching in unsorted section of array and discard sorted portion
            // [18, 2, 5, 6, 8, 11, 12, 15] let say mid in at 6
            if (nums[mid] > nums[start]) //(some condition)
            {
                //adjust start
                start = next;
            }
            else
            {
                //adjust end
                end = prev;
            }
        }

        //if not return with in the while loop, then array is already sorted
        // return 1st element in array
        return nums[0];
    }
}