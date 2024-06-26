namespace BinarySearch;

public class FindCeilingNumber
{
    public int Solution(int[]? nums, int number)
    {
        if (nums == null || nums.Length == 0)
        {
            return -1;
        }

        if (nums.Length == 1)
        {
            return nums[0];
        }

        int start = 0;
        int end = nums.Length - 1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == number)
            {
                return nums[mid];
            }

            if (nums[mid] > number)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return nums[start];
    }
}