namespace Stack;

public class MaxAreaOfHistogram
{
    public int Solution(int[]? nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        if (nums.Length == 1)
        {
            return nums[0];
        }

        int[] lSmallIndex = new int[nums.Length];
        int[] rSmallIndex = new int[nums.Length];

        getLeftMinIndex(nums, lSmallIndex);
        getRightSmallIndex(nums, rSmallIndex);

        int maxValue = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            int value = (rSmallIndex[i] - (lSmallIndex[i] + 1)) * nums[i];
            maxValue = Math.Max(value, maxValue);
        }

        return maxValue;
    }

    private void getRightSmallIndex(int[] nums, int[] rSmallIndex)
    {
        int rightMaxValue = nums.Length;
        Stack<map> rStack = new Stack<map>();

        
        for (int i = nums.Length-1; i >=0; i--)
        {
            if (rStack.Count == 0)
            {
                rSmallIndex[i] = rightMaxValue;
            }

            while (rStack.Count > 0 && rStack.Peek().value > nums[i])
            {
                rStack.Pop();
            }

            if (rStack.Count > 0)
            {
                rSmallIndex[i] = rStack.Peek().index;
            }
            else
            {
                rSmallIndex[i] = rightMaxValue;
            }

            rStack.Push(new map(nums[i], i));
        }
    }

    private void getLeftMinIndex(int[] nums, int[] lSmallIndex)
    {
        int leftMinValue = -1;
        Stack<map> lStack = new Stack<map>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (lStack.Count == 0)
            {
                lSmallIndex[i] = leftMinValue;
            }

            while (lStack.Count > 0 && lStack.Peek().value > nums[i])
            {
                lStack.Pop();
            }

            if (lStack.Count > 0)
            {
                lSmallIndex[i] = lStack.Peek().index;
            }
            else
            {
                lSmallIndex[i] = leftMinValue;
            }

            lStack.Push(new map(nums[i], i));
        }
    }

    public class map
    {
        public int value { get; set; }
        public int index { get; set; }

        public map(int value, int index)
        {
            this.value = value;
            this.index = index;
        }
    }
}