namespace Stack;

public class RainWaterTrapping
{
    public int Solution(int[]? nums)
    {
        if (nums == null || nums.Length < 3)
        {
            return 0;
        }

        int sum = 0;

        int[] leftMax = new int[nums.Length];
        leftMax[0] =nums[0];
        int[] rightMax = new int[nums.Length];
        rightMax[nums.Length-1] = nums[nums.Length - 1];
        
        for (int i = 1; i < nums.Length; i++)
        {
            leftMax[i] = leftMax[i-1] > nums[i] ? leftMax[i-1] : nums[i];
        }

        for (int i = nums.Length-2; i>=0; i--)
        {
            rightMax[i] = rightMax[i+1] > nums[i] ? rightMax[i+1] : nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            sum += Math.Min(leftMax[i], rightMax[i]) - nums[i];
        }

        return sum;
    }
}