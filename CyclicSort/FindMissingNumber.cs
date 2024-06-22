using System.Runtime.InteropServices.Marshalling;

namespace CyclicSort;

public class FindMissingNumber
{
    //Q -> n will be equal to nums.length or equal to nums.length +1
    //should be nums.length
    // 0-4 element array, length should be 5, so n = 5, but due to missing element effective length is 4
    // so idealy n should be 5
    public int? solution(int[]? nums)
    {
        if (nums == null)
        {
            return null;
        }

        // validation for num.Length = n-1 
        int i = 0;
        int pr = 0;
        while (i < nums.Length)
        {
            if (nums[i] == i)
            {
                i++;
            }
            else
            {
                bool result = Swap(nums, i, nums[i]);
                if (!result)
                {
                    pr = i;
                    i++;
                }
            }
        }

        // Console.WriteLine(pr);
        // for (int j = 0; j < nums.Length; j++)
        // {
        //     if (nums[j] != j)
        //     {
        //         return j;
        //     }
        // }

        return pr;
    }

    private static bool Swap(int[] nums, int i, int num)
    {
        if (num < nums.Length)
        {
            (nums[i], nums[num]) = (nums[num], nums[i]);
            return true;
        }

        return false;
    }

    public int? Solution2(int[]? nums)
    {
        if (nums == null || nums.Length < 1)
        {
            return null;
        }

        int i = 0;
        while (i < nums.Length)
        {
            int ci = nums[i];
            if(nums[i]<nums.Length && nums[i]!=nums[ci])
            {
               (nums[ci], nums[i]) = (nums[i],nums[ci]);
            }
            else
            {
                i++;
            }
        }
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] != j)
            {
                return j;
            }
        }
        return null;
    }
}