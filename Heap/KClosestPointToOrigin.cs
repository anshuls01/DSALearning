namespace Heap;

public class KClosestPointToOrigin
{
    public List<int[]> getClosetPair(List<int[]> coordinates, int k)
    {
        List<int[]> result = new List<int[]>();
        if (coordinates == null || coordinates.Count < k)
        {
            return result;
        }

        PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        foreach (int[] pair in coordinates)
        {
            int distance = pair[0] * pair[0] + pair[1] * pair[1];
            pq.Enqueue(pair,distance);
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