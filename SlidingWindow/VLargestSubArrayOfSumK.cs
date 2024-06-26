namespace SlidingWindow;

public class VLargestSubArrayOfSumK
{
    public int Solution(int[]? nums, int k)
    {
        if (nums == null || nums.Length == 0)
        {
            return -1;
        }

        //Queue<int> queue = new Queue<int>();
        int count = 0;
        int start = 0;
        int end = 0;
        int rSum = 0;
        int largestSubArraySize = 0; //4,1,1,1,2,3,5  
        while (end < nums.Length)
        {
            rSum += nums[end];
            count++;//2
            if (rSum >= k)
            {
                if (rSum == k)
                {
                    largestSubArraySize = Math.Max(largestSubArraySize, count);//2
                }

                while (rSum > k)
                {
                    rSum -= nums[start];
                    start++;
                    count--;
                }
            }

            end++;
        }

        return largestSubArraySize;
    }
}