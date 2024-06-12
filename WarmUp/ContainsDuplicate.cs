namespace WarmUp;

public class ContainsDuplicate
{
    public bool solution(int[] arr)
    {
        // i can create a hashset if adding gives -ve result return true else continue
        // t: O(n), S: O(x) x-> number of unique values in input array
        HashSet<int> numbers = new HashSet<int>();
        foreach (int n in arr)
        {
            bool result = numbers.Add(n);
            if (!result)
            {
                return true;
            }
        }

        return false;
    }
}