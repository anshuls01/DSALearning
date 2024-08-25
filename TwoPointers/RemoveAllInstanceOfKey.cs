namespace TwoPointers;

public class RemoveAllInstanceOfKey
{
    public int solution(int[] nums, int key)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == key)
            {
                count++;
            }
        }

        return nums.Length - count;
    }

    public void solution_PrintArray(int[] nums, int key)
    {
        if (nums == null || nums.Length == 0)
        {
            return;
        }

        
        int pointer = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != key)
            {
                nums[pointer] = nums[i];
                pointer++;
            }
        }
        


    }
}