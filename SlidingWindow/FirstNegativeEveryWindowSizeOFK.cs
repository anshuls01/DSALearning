namespace SlidingWindow;

public class FirstNegativeEveryWindowSizeOFK
{
    public List<int> find(int[] nums, int k)
    {
        List<int> result = new List<int>();
        if (nums == null || nums.Length == 0)
        {
            return result;
        }

        int start = 0;
        int end = 0;
        Queue<int> queue = new Queue<int>();
        while (end < nums.Length)
        {
            if (nums[end] < 0)
            {
                queue.Enqueue(nums[end]);
            }

            if (end - start + 1 == k)
            {
                if (queue.Count > 0)
                {
                    result.Add(queue.Peek());
                }
                else
                {
                    result.Add(0);
                }

                if (queue.Count > 0 && nums[start] == queue.Peek())
                {
                    queue.Dequeue();
                }

                start++;
            }

            end++;
        }

        return result;
    }
}