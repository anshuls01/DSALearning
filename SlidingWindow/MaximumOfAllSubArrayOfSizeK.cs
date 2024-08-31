namespace SlidingWindow;

public class MaximumOfAllSubArrayOfSizeK
{
    public List<int> Solution(int[]? nums, int k)
    {
        List<int> result = new List<int>();
        if (nums == null || nums.Length < k)
        {
            return result;
        }

        int start = 0;
        int end = 0;
        int currentMax = int.MinValue;
        Stack<int> stack = new Stack<int>();
        
        while (end < nums.Length)
        {
            while (stack.Count > 0 && stack.Peek() < nums[end])
            {
                stack.Pop();
            }
            stack.Push(nums[end]);
            currentMax = Math.Max(currentMax, nums[end]);
            if (end - start + 1 == k)
            {
                result.Add(currentMax);
                if (nums[start] == currentMax)
                {
                    if (stack.Peek() == currentMax)
                    {
                        //stack.Pop();
                        if (stack.Count > 0)
                            currentMax = stack.Peek();
                    }
                }

                start++;
            }

            end++;
        }

        return result;
    }
    
    public List<int> Solution2(int[]? nums, int k)
    {
        List<int> result = new List<int>();
        if (nums == null || nums.Length < k)
        {
            return result;
        }

        int start = 0;
        int end = 0;
        Queue<int> queue = new Queue<int>();
        while (end < nums.Length)
        {
            while (queue.Count > 0 && queue.Peek() < nums[end])
            {
                queue.Dequeue();
            }
            queue.Enqueue(nums[end]);
            if (end - start + 1 == k)
            {
                result.Add(queue.Peek());
                if (nums[start] == queue.Peek())
                {
                    queue.Dequeue();
                }
                start++;
            }

            end++;
        }

        return result;
    }
    
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        List<int> result = new List<int>();
        List<int> items = new List<int>();
        if(nums==null || nums.Length==0)
        {
            return null;
        }

        if(nums.Length<=k)
        {
            return new int[]{nums.Max()};
        }

        //Queue<int> queue = new Queue<int>();
        int start = 0;
        int end = 0;
        while(end<nums.Length)
        {
            
            while(items.Count>0 && items[items.Count-1]<nums[end])
            {
                items.RemoveAt(items.Count-1);
            }
            
            //Items.Insert(nums[end],0);
            items.Add(nums[end]);

            if(end-start+1==k)
            {
                result.Add(items[0]);
                if(items.Count>0 && items[0]==nums[start])
                {
                    items.RemoveAt(0);
                }
                start++;
            }
            end++;
        }

        return result.ToArray();
    }
}