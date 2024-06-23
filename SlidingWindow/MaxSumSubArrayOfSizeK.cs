namespace SlidingWindow;

public class MaxSumSubArrayOfSizeK
{
    public int Solution(int[]? nums, int k)
    {
        if (nums == null || nums.Length<k)
        {
            return -1;
        }

        int MaxSum = int.MinValue;
        int start = 0;
        int end = 0;
        int rSum = 0;
        while (end<nums.Length)
        {
            rSum += nums[end];
            if (end-start + 1 == k)
            {
                MaxSum = Math.Max(MaxSum, rSum);
                rSum -= nums[start];
                start++;
            }
            
            end++;
        }
        return MaxSum;
    }
}