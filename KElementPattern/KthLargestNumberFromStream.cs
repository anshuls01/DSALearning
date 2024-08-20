namespace KElementPattern;

public class KthLargestNumberFromStream
{
    private readonly int size;
    private readonly PriorityQueue<int, int> pq;
    public KthLargestNumberFromStream(int[] nums, int k)
    {
        size = k;
        pq = new PriorityQueue<int, int>();
        initializeQueue(nums);
    }

    public int Add(int n)
    {
        pq.Enqueue(n,n);
        resizeHeap();
        return pq.Peek();
    }

    private void resizeHeap()
    {
        if (pq.Count > size)
        {
            pq.Dequeue();
        }
    }

    private void initializeQueue(int[] nums)
    {
        foreach (int n in nums)
        {
            pq.Enqueue(n,n);
            resizeHeap();
        }
    }

}