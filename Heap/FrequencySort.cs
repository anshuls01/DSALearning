namespace Heap;

public class FrequencySort
{
    public List<int> get(int[] nums)
    {
        List<int> result = new List<int>();
        if (nums == null || nums.Length == 0)
        {
            return result;
        }

        Dictionary<int, int> freqMap = getFrequancyMap(nums);

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        foreach (int key in freqMap.Keys)
        {
            pq.Enqueue(key, freqMap[key]);
        }

        while (pq.Count > 0)
        {
            int element = pq.Dequeue();
            int count = freqMap[element];
            while (count > 0)
            {
                result.Add(element);
                count--;
            }
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