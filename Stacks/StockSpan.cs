namespace Stack;

public class StockSpan
{
    public int[]? Solution(int[]? nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return nums;
        }

        // the bewlo lopp should not be needed
        // if (nums.Length == 1)
        // {
        //     return new int[] { 1 };
        // }

        int[] result = new int[nums.Length];
        int minValue = 1;
        Stack<map> stack = new Stack<map>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (stack.Count == 0)
            {
                result[i] = minValue;
            }

            while (stack.Count > 0 && stack.Peek().value < nums[i])
            {
                stack.Pop();
            }

            if (stack.Count > 0)
            {
                result[i] = i-stack.Peek().index ;
            }
            else
            {
                result[i] = minValue;
            }
            stack.Push(new map(nums[i],i));

        }


        return result;
    }

    public class map
    {
        public int value;
        public int index;

        public map(int value, int index)
        {
            this.value = value;
            this.index = index;
        }
    }

}