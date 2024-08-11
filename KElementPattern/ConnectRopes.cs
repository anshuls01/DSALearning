namespace KElementPattern;

public class ConnectRopes
{
    public int cost(int[] nums)
    {
        int totalCost = 0;
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();//min heap
        foreach (int n in nums)
        {
            pq.Enqueue(n,n);
        }

        while (pq.Count >= 2)
        {
            int first = pq.Dequeue();
            int second = pq.Dequeue();
            int newLength = first + second;
            totalCost += newLength;
            pq.Enqueue(newLength,newLength);
        }

        return totalCost;
    }
}