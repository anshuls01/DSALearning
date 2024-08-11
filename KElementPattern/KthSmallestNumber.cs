namespace KElementPattern;

public class KthSmallestNumber
{
    public int find(int[] nums, int k)
    {
        int element = 0;

        if (nums == null || nums.Length < k)
        {
            return element;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        foreach (int n in nums)
        {
            pq.Enqueue(n,n);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        element = pq.Dequeue();
        return element;
    }
}