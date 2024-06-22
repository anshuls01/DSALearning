using System.Text;

namespace CyclicSort;

public class SortArray
{
    public int[]? Solution(int n, int[]? nums)
    {
        if (nums == null || nums.Length < 2)
        {
            return nums;
        }
        if (n <= 1)
        {
            return nums;
        }
        if (!n.Equals(nums.Length))
        {
            //return nums;
            n = nums.Length;
        }

        //in this I didn't use of given n but why?
        int i = 1;
        while (i < n)
        {
            int index = i - 1;
            if (nums[index] == i)
            {
                i++;
            }
            else
            {
                Replace(nums, i, nums[index]);
            }
        }

        return nums;
    }

    private static void Replace(int[] nums, int i, int number)
    {
        (nums[number - 1], nums[i - 1]) = (nums[i - 1], nums[number - 1]);
    }
    
    // private void replace(int[] nums, int i, int number)
    // {
    //     int temp = nums[number - 1];
    //     nums[number - 1] = nums[i - 1];
    //     nums[i - 1] = temp;
    // }
}