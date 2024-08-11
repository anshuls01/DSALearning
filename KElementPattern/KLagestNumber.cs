using System.Security.Principal;

namespace KElementPattern;

public class KLagestNumber
{
    public List<int> find(int[] nums, int k)
    {
        List<int> result = new List<int>();
        if (nums == null | nums.Length < k)
        {
            return result;
        }

        //SortedSet<Tuple<int, int>> pq = new SortedSet<Tuple<int, int>>(Comparer<Tuple<int, int>>.Create((a, b) => a.Item1.CompareTo(b.Item1)));
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach (int n in nums)
        {
            pq.Enqueue(n,n);
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