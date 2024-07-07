namespace BinarySearch;

public class FirntFirstOneInBinarySortedInfiniteArray
{
    public int find(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return -1;
        }

        if (nums[0] == 1)
        {
            return 0;
        }

        int start = 0;
        int end = start + 1;
        while (end<nums.Length && nums[end] < 1)
        {
            start = end;
            int pend = start * 2;
            if (pend > nums.Length)
            {
                end = nums.Length - 1;
            }
            else
            {
                end = pend;
            }
        }

        int result = -1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == 1)
            {
                result = mid;
                end = mid - 1;
            }
            else if (nums[mid] < 1)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return result;
    }
}