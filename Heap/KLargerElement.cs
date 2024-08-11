namespace Heap;

public class KLargerElement
{
    public int[] find(int[] arr, int k)
    {
        int[] result = new int[k];
        if (arr == null || arr.Length < k)
        {
            return result;
        }

        // create a max heap -> max heap element will be on top
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));
        int size = arr.Length - k;
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int num = arr[i];
            pq.Enqueue(num, num);
            if (pq.Count > size)
            {
                if (count < result.Length)
                {
                    result[count] = pq.Dequeue();
                    count++;
                }
            }
        }
        return result;
    }
    
    
    //with min heap
    public int[] find1(int[] arr, int k)
    {
        int[] result = new int[k];
        if (arr == null || arr.Length < k)
        {
            return result;
        }

        // create a min heap -> min element will be on top, removing the minimum element from top, remaining will be top K larger element.
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        
        for (int i = 0; i < arr.Length; i++)
        {
            int num = arr[i];
            pq.Enqueue(num, num);
            if (pq.Count > k)
            {
                 pq.Dequeue();
            }
        }

        int index = 0;
        while (pq.Count > 0)
        {
            result[index] = pq.Dequeue();
            index++;
        }

        return result;
    }
}