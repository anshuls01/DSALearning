namespace TwoPointers;

public class TripletSumToZero
{
    public List<int[]> findTriplets(int[] nums)
    {
        List<int[]> result = new List<int[]>();
        if (nums == null || nums.Length < 3)
        {
            return result;
        }

        HashSet<int> visited = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!visited.Contains(nums[i]))
            {
                visited.Add(nums[i]);
                List<int[]> pairs = findPair(nums, i+1, 0 - nums[i]);
                if (pairs != null)
                {
                    foreach (int[] pair in pairs)
                    {
                        int[] triplet = new int[] { nums[i], pair[0], pair[1] };
                        result.Add(triplet);
                    }
                }
            }
        }

        return result;
    }

    private List<int[]> findPair(int[] nums, int start, int sum)
    {
        List<int[]> pairs = new List<int[]>();
        HashSet<int> set = new HashSet<int>();
        HashSet<int> visited = new HashSet<int>();
        for (int i = start; i < nums.Length; i++)
        {
            if (!visited.Contains(nums[i]))
            {
                visited.Add(nums[i]);
                int value = sum - nums[i];
                if (set.Contains(value))
                {
                    int[] pair = new int[] { nums[i], value };
                    pairs.Add(pair);
                }
                set.Add(nums[i]);
            }
        }

        return pairs;
    }
    
    public List<List<int>> findTriplets_Sorting(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();
        if (nums == null || nums.Length < 3)
        {
            return result;
        }

        Array.Sort(nums);// t: O(nlogn) s: O(n)
        for(int i = 0;i<nums.Length-2;i++)
        {
            if(i>0 && nums[i]==nums[i-1]) // to avoid duplicate triplet
            {
                continue;
            }
            List<List<int>> pairs = findUniquePairs(nums, i+1,-nums[i]);
            if(pairs!=null)
            {
                foreach (List<int> pair in pairs)
                {
                    List<int> triplet = new List<int> { nums[i], pair[0], pair[1] };
                    result.Add(triplet);
                }
            }
        }
        return result;
    }

    private List<List<int>> findUniquePairs(int[] nums,int start,int sum)
    {
        List<List<int>> pairs = new List<List<int>>();
        int end = nums.Length-1;
        while(start<end)
        {
            int possibleSum = nums[start] + nums[end];
            if(sum == possibleSum)
            {
                pairs.Add(new List<int> { nums[start], nums[end] });
                start++;
                end--;
                while(start<end && nums[start]==nums[start-1])
                {
                    start++;
                }

                while(start<end && nums[end]==nums[end+1])
                {
                    end--;
                }
            }
            else if(possibleSum>sum)
            {
                end--;
            }
            else
            {
                start++;
            }
           

        }

        return pairs;
    }

}