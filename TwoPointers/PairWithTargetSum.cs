namespace TwoPointers;

public class PairWithTargetSum
{
    public int[]? findPair(int[]? nums, int target)
    {
        if (nums == null || nums.Length < 2)
        {
            return null;
        }

        int start = 0;
        int end = nums.Length - 1;
        while (start < end)
        {
            int sum = nums[start] + nums[end];
            if (sum == target)
            {
                return new int[] { start, end };
            }

            if (sum > target)
            {
                end--;
            }
            else
            {
                start++;
            }
        }
        return null;
    }
}