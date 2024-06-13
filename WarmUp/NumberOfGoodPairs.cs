namespace WarmUp;

public class NumberOfGoodPairs
{
    //T: O(n^2) S: O(1)
    public int GoodPair_On2(int[]? nums)
    {
        if (nums == null || nums.Length <= 1)
        {
            return 0;
        }

        int count = 0;
        List<int[]> pairs = new List<int[]>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                    pairs.Add(new int[] { i, j });
                }
            }
        }
        

        if (pairs.Count > 0)
        {
            foreach (int[] pair in pairs)
            {
                Console.WriteLine(string.Join(",", pair));
            }
        }

        return count;
    }
    
    
    //T: O(n) s: O(n)
    public int GoodPair_On(int[]? nums)
    {
        if (nums == null || nums.Length <= 1)
        {
            return 0;
        }
        int count = 0;
        //if just needs only pair count
        Dictionary<int, int> map = new Dictionary<int, int>();
        // the below data structure is more suitable to return list of good pair
        //Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if(!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = 1;
            }
            else
            {
                count += map[nums[i]];
                map[nums[i]]++;
            }
        }
        return count;
    }
}