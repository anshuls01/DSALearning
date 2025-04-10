using System;

namespace Meta.Strings;

public class ThreeSumWithHashSet
{
    public void solve(int[] nums)
    {
        if(nums==null || nums.Length<3)   
        {
            return;
        }

        Array.Sort(nums);
        //sorting not doing -> save nlogn
        for(int i = 0;i<nums.Length && nums[i]<=0;i++)
        {
            if(i == 0 || nums[i]!=nums[i-1])
            {
                List<int[]> pairs = find(nums, i+1,nums.Length-1, -nums[i]);
                foreach(int[] pair in pairs)
                {
                    Console.WriteLine($"{nums[i]},{pair[0]},{pair[1]}");
                }
            }
        }
    }

    private List<int[]> find(int[] nums, int start,int end, int target)
    {
        List<int[]> pairs = new List<int[]>();
        HashSet<int> set = new HashSet<int>();

        for(int i = start;i<=end;i++)
        {
            int compliment = target-nums[i];
            if(set.Contains(compliment))
            {
                pairs.Add([nums[i], compliment]);
            }
            else
            {
                set.Add(nums[i]);
            }
        }

        return pairs;
    }
}
