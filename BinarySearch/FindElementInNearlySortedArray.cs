namespace BinarySearch;

public class FindElementInNearlySortedArray
{
    public int find(int[]? nums, int element)
    {
        if (nums == null || nums.Length == 0)
        {
            return -1;
        }

        int start = 0;
        int end = nums.Length - 1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            int prev = mid - 1;
            int next = mid + 1;

            if (nums[mid] == element)
            {
                return mid;
            }
            else if (prev>=0 && nums[prev] == element)
            {
                return prev;
            }
            else if(next<nums.Length && nums[next]==element)
            {
                return next;
            }

            if (prev >= 0 && nums[prev] > element)
            {
                end = prev-1;
            }
            else
            {
                start = next+1;
            }
        }

        return -1;
    }
}