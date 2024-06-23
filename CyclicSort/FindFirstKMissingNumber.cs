namespace CyclicSort;

public class FindFirstKMissingNumber
{
    public List<int> findNumbers(int[] nums, int k) {
        List<int> missingNumbers = new List<int>();
        HashSet<int> extraNumbers = new HashSet<int>();
        // TODO: Write your code here
        int i = 0;
        while(i<nums.Length)
        {
            int ci = nums[i]-1;
            if(nums[i]>0 && nums[i]<=nums.Length && nums[i]!=nums[ci])
            {
                swap(nums,i,ci);
            }
            else
            {
                i++;
            }
        }

        int j = 0;
        while(k>0 && j<nums.Length)
        {
            if(nums[j]!=j+1)
            {
                missingNumbers.Add(j+1);
                extraNumbers.Add(nums[j]);
                k--;
            }
            j++;
        }

        int l = 1;
        while(k>0)
        {
            int candidate = l + nums.Length;
            if (!extraNumbers.Contains(candidate))
            {
                missingNumbers.Add(candidate);
                k--;
            }

            l++;
        }
        return missingNumbers;
    }
    private void swap(int[] nums, int i, int ci)
    {
        (nums[ci], nums[i]) = (nums[i], nums[ci]);
    }

}