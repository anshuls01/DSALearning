namespace Heap;

public class KthLargestElement
{
    public int find(int[] arr, int k)
    {
        if (arr == null || arr.Length < k)
        {
            return -1;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            int current = arr[i];
            pq.Enqueue(current,current);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        return pq.Peek();
    }
    
    
}