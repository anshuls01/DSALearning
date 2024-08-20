namespace KElementPattern;

public class KClosestNumber
{

    public List<int> findClosestInSortedArray(int[] nums, int k, int x)
    {
        List<int> result = new List<int>();
        //if its a sorted array, then use Binary search to find the element
        //if found great, else left and right are two possibilities

        if (nums == null || nums.Length < k)
        {
            return result;
        }

        int index = findIndex(nums, x);
        int leftIndex = index;
        int rightIndex = index + 1;
            
        for (int i = 0; i < k; i++)
        {
            if (leftIndex >= 0 && rightIndex < nums.Length)
            {
                int leftDiff = Math.Abs(x - nums[leftIndex]);
                int rightDiff = Math.Abs(x - nums[rightIndex]);
                if (leftDiff > rightDiff)
                {
                    result.Insert(0,nums[rightIndex]);
                    rightIndex++;
                }
                else
                {
                    result.Add(nums[leftIndex]);
                    leftIndex--;
                }
            }
            else if (leftIndex >= 0)
            {
                result.Add(nums[leftIndex]);
                leftIndex--;
            }
            else if (rightIndex < nums.Length)
            {
                result.Add(nums[rightIndex]);
                rightIndex++;
            }
        }

        return result;
    }

    private int findIndex(int[] nums, int x)
    {
        int start = 0;
        int end = nums.Length - 1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == x)
            {
                return mid;
            }

            if (nums[mid] > x)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        if (start > 0)
        {
            return start - 1;
        }

        return start;
    }

    public List<int> find(int[] nums, int k, int x)
    {

        List<int> result = new List<int>();
        if (nums == null || nums.Length < k)
        {
            return result;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        foreach (int n in nums)
        {
            pq.Enqueue(n, Math.Abs(n-x));
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