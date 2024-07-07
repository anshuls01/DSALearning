namespace BinarySearch;

public class NoOfTimeArrayRotated
{
    // find min element in sorted array, 
    // no of time array sorted is array.Length - minindex

    public int findMinIndex(int[]? nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return -1;
        }

        int start = 0;
        int end = nums.Length - 1;
        int n = nums.Length;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            int prev = (mid + n - 1) % n;
            int next = (mid + 1) % n;

            if (nums[mid] <= nums[prev] && nums[mid] <= nums[next])
            {
                return n - mid;
            }
            //finding unsorted array
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
}