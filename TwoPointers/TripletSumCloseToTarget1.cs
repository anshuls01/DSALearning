namespace TwoPointers;

public class TripletSumCloseToTarget1
{
    public int? solution(int[]? nums, int target)
    {
        if (nums == null || nums.Length < 3)
        {
            return null;
        }
        int closestSum = int.MaxValue;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int start = i + 1;
            int end = nums.Length - 1;

            while (start < end)
            {
                int num1 = nums[start];
                int num2 = nums[end];
                int sum = nums[i] + num1 + num2;
                if (sum==target)
                {
                    return sum;
                }
                // if (Math.Abs(diff) < Math.Abs(closestSum) || Math.Abs(diff) == Math.Abs(closestSum) && diff > closestSum)
                // {
                //     closestSum = diff;
                // }
                int diff = target - sum;
                if (Math.Abs(target - sum) < Math.Abs(target - closestSum))
                {
                    closestSum = sum;
                }
                // if (Math.Abs(diff) < Math.Abs(closestSum) || (Math.Abs(diff)==Math.Abs(closestSum) && diff>closestSum))
                // {
                //     closestSum = sum;
                // }
                
                if (sum<target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
                //
                // int diffToTarget = Math.Abs(target-sum);
                // if (diffToTarget < Math.Abs(closest) || Math.Abs(diffToTarget)==Math.Abs(closest) && diffToTarget>closest)
                // {
                //     closest = diffToTarget;
                //     resultSum = sum;
                // }
            }
        }

        return closestSum;
    }

}