using System.Runtime.InteropServices.Marshalling;

namespace CyclicSort;

public class FindAllDiaspearedNumberInAArray
{
    public List<int> Solution(int[]? nums)
    {
        List<int> missingNumbers = new List<int>();
        if (nums == null || nums.Length < 1)
        {
            return missingNumbers;
        }

        int i = 0;
        while (i < nums.Length)
        {
            if (nums[i] == i + 1)
            {
                i++;
            }
            else
            {
                bool result = Swap(nums, i, nums[i]);
                if (!result)
                {
                    i++;
                }
            }
        }

        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] != j + 1)
            {
                missingNumbers.Add(j+1);
            }
        }

        return missingNumbers;
    }

    private bool Swap(int[] nums, int i, int number)
    {
        int c = number - 1;
        if (nums[i] != nums[c])
        {
            (nums[i], nums[c]) = (nums[c], nums[i]);
            return true;
        }

        return false;
    }
}