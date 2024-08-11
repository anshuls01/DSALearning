namespace Heap;

public class KthSmallestElement
{
    public int find(int[] arr, int k)
    {
        if (arr == null || arr.Length < k)
        {
            return -1;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        for (int i = 0; i < arr.Length; i++)
        {
            int current = arr[i];
            pq.Enqueue(current,current);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        return pq.Dequeue();
    }
}