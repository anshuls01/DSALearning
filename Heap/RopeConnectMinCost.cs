namespace Heap;

public class RopeConnectMinCost
{
    public int find(int[] nums)
    {
        int minCost = 0;
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        foreach (int n in nums)
        {
            pq.Enqueue(n, n);
        }

        while (pq.Count >=2)
        {
            int first = pq.Dequeue();
            int second = pq.Dequeue();
            int newLength = first + second;
            minCost += newLength;
            pq.Enqueue(newLength, newLength);
        }

        //minCost += pq.Dequeue();
        return minCost;
    }
}