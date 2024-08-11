
namespace Heap;

public class KClosestNumber
{
    public List<int> find(int[] nums, int k, int number)
    {
        List<int> result = new List<int>();
        if (nums == null || nums.Length < k)
        {
            return result;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));
        for (int i = 0; i < nums.Length; i++)
        {
            pq.Enqueue(nums[i], Math.Abs(number-nums[i]));
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
}