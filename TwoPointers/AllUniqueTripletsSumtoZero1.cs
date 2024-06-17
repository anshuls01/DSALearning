namespace TwoPointers;

public class AllUniqueTripletsSumtoZero1
{
    public List<int[]>? solution(int[]? nums)
    {
        if (nums == null || nums.Length < 3)
        {
            return null;
        }

        List<int[]> result = new List<int[]>();
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int num = nums[i]; // here should be the logic to find first non duplicate number
            int target = -num;
            int start = i+1;
            int end = nums.Length - 1;
            List<int[]> pairList = findPair(nums, start, end, target);

            foreach (int[] pair in pairList)
            {
                result.Add(new int[]{num,pair[0],pair[1]});
            }
        }
        return result;
    }

    private List<int[]> findPair(int[] nums, int start, int end, int target)
    {
        List<int[]> pairList = new List<int[]>();
        while (start < end)
        {
            int num1 = nums[start];
            int num2 = nums[end];
            int sum = num1 + num2;
            if (sum == target)
            {
                pairList.Add(new int[] { num1, num2 });
                start++;
                end--;
                
            }
            else if (sum > target)
            {
                end--;
                while (start < end && num2 == nums[end])
                {
                    end--;
                }
            }
            else
            {
                start++;
                while (start < end && num1 == nums[start])
                {
                    start++;
                }
            }
        }

        return pairList;
    }
}