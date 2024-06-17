namespace TwoPointers;

public class AllUniqueTripletsSumtoZero
{
    //problems in the below implementation not able to avoid duplicate
    //one easy way to avoid duplicate in array, sort the array and leave the duplicate items
    public List<int[]>? find(int[]? nums)
    {
        if (nums == null || nums.Length < 3)
        {
            return null;
        }

        List<int[]> list = new List<int[]>();
        HashSet<int> numbers = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            bool result = numbers.Add(nums[i]);
            if (result)
            {
                List<int[]> pairList = findTargetSum(nums, i, -nums[i]);
                foreach (int[] pair in pairList)
                {
                    list.Add(new int[] { nums[i], pair[0], pair[1] });
                }
            }
        }

        return list;
    }

    private List<int[]> findTargetSum(int[] nums, int leftIndex, int targetSum)
    {
        Dictionary<int, int> compliments = new Dictionary<int, int>();
        List<int[]> pairList = new List<int[]>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (i != leftIndex)
            {
                int reminder = targetSum - nums[i];
                if (!compliments.ContainsKey(reminder))
                {
                    compliments[nums[i]] = reminder;
                }
                else
                {
                    int[] pair = new int[] { nums[i], reminder };
                    Array.Sort(pair);
                    if (validPair(pair, pairList))
                    {
                        pairList.Add(new int[] { pair[0], pair[1] });
                    }
                }
            }
        }

        return pairList;
    }

    private bool validPair(int[] pair, List<int[]> pairs)
    {
        foreach (int[] p in pairs)
        {
            if (p[0] == pair[0] && p[1] == pair[1])
            {
                return false;
            }
        }

        return true;
    }

    //t: O(n^2) + O(nlogn) = O(n^2), s: O(n) coming from sorting, and ignoring space used by triplets
    public List<int[]>? finTriplets(int[]? nums)
    {
        //edge case
        if (nums == null || nums.Length < 3)
        {
            return null;
        }

        List<int[]> triplets = new List<int[]>();
        Array.Sort(nums); //t: O(nlogn) s: o(n)

        //t: O(n^2)  one is immediate loop and another loop in findpairs function
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int targetSum = nums[i];
            int start = i + 1;
            int end = nums.Length - 1;
            List<int[]> pairs = findPairs(nums, start, end, -targetSum);
            foreach (int[] pair in pairs)
            {
                triplets.Add(new int[] { targetSum, pair[0], pair[1] });
            }
        }

        return triplets;
    }

    private List<int[]> findPairs(int[] nums, int start, int end, int targetSum)
    {
        List<int[]> pairs = new List<int[]>();
        while (start < end)
        {
            int num1 = nums[start];
            int num2 = nums[end];
            int sum = num1 + num2;
            if (sum == targetSum)
            {
                pairs.Add(new int[] { num1, num2 });
                start++;
                end--;
            }
            else if (sum > targetSum)
            {
                end--;
                while (end > start && num2 == nums[end])
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

        return pairs;
    }
}