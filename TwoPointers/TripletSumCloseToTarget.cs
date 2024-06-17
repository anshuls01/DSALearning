namespace TwoPointers;

public class TripletSumCloseToTarget
{
    //attempt 1 -> t: O(n^3) + logn s: o(n) + o(n)
    public int? find(int[]? nums, int target)
    {
        if (nums == null || nums.Length < 3)
        {
            return null;
        }

        Array.Sort(nums); //onlogn
        List<int> tripletSum = new List<int>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    // int k = j + 1;
                    tripletSum.Add(nums[i] + nums[j] + nums[k]);
                }
            }
        }

        return findClosestNumber(tripletSum.ToArray(), target);
    }

    private int findClosestNumber(int[] num, int n)
    {
        int start = 0;
        int end = num.Length - 1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            int number = num[mid];
            if (number == n)
            {
                return number;
            }

            if (number > n)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return num[end];
    }

    // [-3, -1 , 1, 2] target: 1
    public int? find_attemptTwo(int[]? nums, int target)
    {
        if (nums == null || nums.Length < 3)
        {
            return null;
        }

        Array.Sort(nums);

        int minValue = int.MaxValue;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int start = i + 1;
            int end = nums.Length - 1;
            while (start < end)
            {
                int reminder = target - nums[i] - nums[start] - nums[end];
                if (reminder == 0)
                {
                    return reminder;
                }

                if (Math.Abs(reminder) < Math.Abs(minValue)|| (Math.Abs(reminder)==Math.Abs(minValue) && reminder>minValue))
                {
                    minValue = reminder;
                }

                if (reminder > 0)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            //
            // int reminder = target - nums[i];  //4
            // int result = findMin(nums, start, end, reminder) ;
            // minValue = Math.Min(minValue, result);
            
        }

        return target - minValue;
    }

    //o(n)
    private int findMin(int[] nums, int start, int end, int target)
    {
        int minValue = int.MaxValue;
        while (start < end)
        {
            int num1 = nums[start];
            int num2 = nums[end];
            int sum = num1 + num2;
            int diff = target - sum;
            if (diff==0)
            {
                return diff;
            }
            
//            if (Math.Abs(diff) == Math.Abs(sum) && diff > sum || Math.Abs(sum) == Math.Abs(diff))
            if (Math.Abs(diff) <Math.Abs(minValue)||Math.Abs(diff) ==Math.Abs(minValue) && diff>minValue)
            {
                minValue = diff;
            }

            if (diff<=0)
            {
                end--;
            }
            else
            {
                start++;
            }

            //minValue = Math.Min(sum, minValue);
        }

        return minValue;
    }
}