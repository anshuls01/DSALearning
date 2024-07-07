namespace BinarySearch;

public class findElementInSortedRotatedArray
{
    public int find(int[] nums, int element)
    {
        if (nums == null || nums.Length == 0)
        {
            return -1;
        }

        int minIndex = findMinIndex(nums);
        int end = nums.Length - 1;

        if (nums[minIndex] == element)
        {
            return minIndex;
        }

        if (minIndex == 0) // i.e. array is sorted
        {
            return findElementIndex(nums, 0, end, element);
        }

        if (minIndex + 1 < nums.Length && nums[minIndex] < element && element <= nums[end])
        {
            return findElementIndex(nums, minIndex + 1, end, element);
        }
        
        if (minIndex - 1 >= 0 && nums[0]<=element && element < nums[minIndex - 1])
        {
            return findElementIndex(nums, 0, minIndex - 1, element);
        }

        return -1;
    }

    private int findMinIndex(int[] nums)
    {
        int start = 0;
        int end = nums.Length - 1;
        int n = nums.Length;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            int prev = (mid + n - 1) % n;
            int next = (mid + 1) % n;
            if (nums[mid] <= nums[prev] && nums[mid] <= nums[next])
            {
                return mid;
            }

            if (nums[mid] > nums[start])
            {
                start = next;
            }
            else
            {
                end = prev;
            }
        }

        return 0;
    }


    private int findElementIndex(int[] nums, int start, int end, int element)
    {
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == element)
            {
                return mid;
            }

            if (nums[mid] > element)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return -1;
    }
}