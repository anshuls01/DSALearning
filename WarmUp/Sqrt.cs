namespace WarmUp;

public class Sqrt
{
    //t: O(n)
    public int findSqrt(int num)
    {
        if (num <= 2)
        {
            return 1;
        }

        int Squareroot = 1;
        int max = num / 2;
        for (int i = 1; i <= max; i++)
        {
            int possibleSqrt = i * i;
            Squareroot = possibleSqrt <= num ? i : Squareroot;
        }

        return Squareroot;
    }

    // this can be solve easily by binary search
    // range is 1 to num/2
    // t: log(n)
    public int findSqrt_BS(int num)
    {
        if (num <= 2)
        {
            return 1;
        }

        int start = 1;
        int end = num / 2;
        while (start < end)
        {
            int mid = start + (end - start) / 2;
            int possibleSqrt = mid * mid;
            if (num == possibleSqrt)
            {
                return mid;
            }
            
            if (possibleSqrt > num)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return end;
    }
}