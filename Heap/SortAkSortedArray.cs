namespace Heap;

public class SortAkSortedArray
{
    //min heap
    public int[] sort(int[] nums, int k)
    {
        if (nums == null || nums.Length < k)
        {
            return null;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        int start =0;
        for (int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];
            pq.Enqueue(current, current);
            if (pq.Count > k)
            {
                nums[start] = pq.Dequeue();
                start++;
            }
        }

        while (start < nums.Length)
        {
            nums[start] = pq.Dequeue();
            start++;
        }

        return nums;
    }
} 