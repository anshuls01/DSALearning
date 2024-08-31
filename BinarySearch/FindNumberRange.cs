namespace BinarySearch;

public class FindNumberRange
{
    public int[] findRange(int[] arr, int key)
    {
        int[] result = new int[] { -1, -1 };
        // TODO: Write your code here
        int left = findLowestIndex(arr,key, true);
        int right = findLowestIndex(arr,key, false);
        if(left>=0 && right>=0)
        {
            result[0] = left;
            result[1] = right;
        }
        return result;
    }

    private int findLowestIndex(int[] arr,int key, bool leftIndex)
    {
        int start = 0;
        int end = arr.Length-1;
        int pIndex = -1;
        while(start<=end)
        {
            int mid = start + (end-start)/2;
            if(arr[mid]==key)
            {
                pIndex = mid;
                if(leftIndex)
                {
                    end = mid-1;
                }
                else
                {
                    start = mid+1;
                }

            }
            else if(arr[mid]>key)
            {
                end = mid-1;
            }
            else 
            {
                start = mid+1;
            }

        }
        return pIndex;
    }
}