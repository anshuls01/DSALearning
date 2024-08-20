namespace KElementPattern;

public class MaximumDistinctElements
{
    public List<int> find(int[] nums, int k)
    {
        List<int> result = new List<int>();
        if (nums == null || nums.Length == 0)
        {
            return result;
        }

        Dictionary<int, int> freqMap = getFreqMap(nums);
        /* 
            7, 1
            3, 3
            5, 2
            8, 1
	    */
        if (freqMap.Keys.Count == nums.Length)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                result.Add(nums[i]);
            }

            return result;
        }

        // min heap
        PriorityQueue<int, int> pq = initializePriorityQueue(freqMap, result);
        /* 
            5, 2
            3, 3
        */
        int count = 0;
        for (int i = 0; i < k; i++)
        {
            if (pq.Count > 0)
            {
                int key = pq.Dequeue();
                freqMap[key]--;
                if (freqMap[key] == 1)
                {
                    result.Add(key);
                }
                else
                {
                    pq.Enqueue(key, freqMap[key]);
                }

                count++;
            }
        }

        while (k - count > 0)
        {
            result.RemoveAt(result.Count - 1);
            count++;
        }

        return result;
    }

    private Dictionary<int, int> getFreqMap(int[] nums)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = 0;
            }

            map[nums[i]]++;
        }

        return map;
    }

    private PriorityQueue<int, int> initializePriorityQueue(Dictionary<int, int> freqMap, List<int> result)
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach (int key in freqMap.Keys)
        {
            if (freqMap[key] == 1)
            {
                result.Add(key);
            }
            else
            {
                pq.Enqueue(key,freqMap[key]);
            }
        }

        return pq;
    }
}