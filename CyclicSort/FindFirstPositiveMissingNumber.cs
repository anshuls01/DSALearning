namespace CyclicSort;

public class FindFirstPositiveMissingNumber
{
    public int? Solution(int[]? nums)
    {
        if (nums == null || nums.Length < 1)
        {
            return null;
        }

        int i = 0;
        while (i < nums.Length)
        {
            int ci = nums[i] - 1;
            if ((nums[i]<0 || nums[i]>= nums.Length) || (ci<=0 || ci>=nums.Length)  || nums[i] == nums[ci])
            {
                i++;
            }
            else
            {
            
                (nums[i],nums[ci]) = (nums[ci],nums[i]);
            }
        }

        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] > 0 && nums[j] != j + 1)
            {
                return j + 1;
            }
        }

        return null;
    }
}