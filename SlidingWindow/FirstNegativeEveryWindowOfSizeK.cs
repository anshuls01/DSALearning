namespace SlidingWindow;

public class FirstNegativeEveryWindowOfSizeK
{
    public List<int> Solution(int[]? nums, int k)
    {
        List<int> result = new List<int>();

        if (nums == null || nums.Length < k)
        {
            return result;
        }

        Queue<int> queue = new Queue<int>();
        int start = 0;
        int end = 0;
        while (end < nums.Length)
        {
            if (nums[end] < 0)
            {
                queue.Enqueue(nums[end]); 
            }

            if (end - start + 1 == k )
            {
                if (queue.Count > 0)
                {
                    int negative = queue.Peek();
                    result.Add(negative);
                    if (negative == nums[start])
                    {
                        queue.Dequeue();
                    }
                }
                else
                {
                    result.Add(0);
                    
                }

                start++;
            }

            end++;
        }

        return result;
    }
}