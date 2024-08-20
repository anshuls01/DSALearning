namespace KElementPattern;

public class SumOfElements
{
    public int solution(int[] nums, int k1, int k2)
    {
        if(nums==null || nums.Length==0)
        {
            return 0;
        }

        int num1 = findSmallestNumber(nums,k1);
        int num2 = findSmallestNumber(nums,k2);

        return getSum(nums, num1,num2);
    }

    private int findSmallestNumber(int[] nums, int k)
    {
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(Comparer<int>.Create((a,b)=>b.CompareTo(a)));

        for(int i = 0;i<nums.Length;i++)
        {
            pq.Enqueue(nums[i],nums[i]);
            if(pq.Count>k)
            {
                pq.Dequeue();
            }
        }

        return pq.Dequeue();
    }
    private int getSum(int[] nums, int num1, int num2)
    {
        int sum = 0;
        foreach(int n in nums)
        {
            if(n>num1 && n<num2)
            {
                sum +=n;
            }
        }

        return sum;
    }

}