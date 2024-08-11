namespace Heap;

public class TopKFrequentElements
{
    public List<int> find(int[] nums, int k)
    {
        List<int> result = new List<int>();
        if (nums == null || nums.Length < k)
        {
            return result; // clarify always from interviewer what to do?
        }

        Dictionary<int, int> freqMap = getFrequancyMap(nums);
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach (int key in freqMap.Keys)
        {
            pq.Enqueue(key, freqMap[key]);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        while (pq.Count > 0)
        {
            result.Add(pq.Dequeue());
        }

        return result;
    }

    private Dictionary<int, int> getFrequancyMap(int[] nums)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach (int n in nums)
        {
            if (!map.ContainsKey(n))
            {
                map[n] = 0;
            }

            map[n]++;
        }

        return map;
    }

}