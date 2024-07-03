using System.IO.Pipes;
using System.Net.Http.Headers;
using System.Reflection;

namespace TwoPointers;

public class FindNextPalindrome
{
    public int solution(int[]? nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 1;
        }

        // case 1 if number contains all 9;
        int targetNumber = 0;
        bool result = isAll9(nums);
        if (result)
        {
            targetNumber = Convert.ToInt32(Math.Pow(10, nums.Length)) + 1;
            return targetNumber;
        }

        // case 2 if number is palindrome
        if (isPalindrome(nums))
        {
            incrementMiddleValue(nums);
        }
        else
        {
            // case 3 if number is not palindrome
            ConvertToPalindrome(nums);
        }

        return convertToNumber(nums);
    }

    private void ConvertToPalindrome(int[] nums)
    {
        int left = -1;
        int right = -1;
        int mid = nums.Length / 2;
        if (nums.Length % 2 == 0)
        {
            left = mid - 1;
            right = mid;
        }
        else
        {
            left = mid - 1;
            right = mid + 1;
        }

        while (left >= 0 && right < nums.Length && nums[left] == nums[right])
        {
            left--;
            right++;
        }

        bool middleIncreased = false; //9  6   8   7
        while (left >= 0 && right < nums.Length)
        {
            
            if (nums[left] < nums[right] && !middleIncreased)
            {
                incrementMiddleValue(nums);
                middleIncreased = true;
            }
            nums[right] = nums[left];
            left--;
            right++;
        }
    }

    private int convertToNumber(int[] nums)
    {
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            result = result * 10 + nums[i];
        }

        return result;
    }

    private void incrementMiddleValue(int[] nums)
    {
        int mid = nums.Length / 2;
        int length = nums.Length;
        int carry = 1;
        if (length % 2 == 0)
        {
            IncrementLeft(nums, mid - 1, 1);
            IncrementRight(nums, mid, 1);
        }
        else
        {
            IncrementMiddle(nums, mid, 1);
        }
        //edge case to handle if mid is 9 -- done
    }

    private void IncrementMiddle(int[] nums, int mid, int carry)
    {
        if (nums[mid] != 9)
        {
            nums[mid] = nums[mid] + 1;
        }
        else
        {
            nums[mid] = 0;
            IncrementLeft(nums, mid - 1, 1);
            IncrementRight(nums, mid + 1, 1);
        }
    }
    private void IncrementLeft(int[] nums, int left, int carry)
    {
        do
        {
            int number = nums[left] + carry;
            nums[left] = number % 10;
            carry = number / 10;
            left--;
        } while (left >= 0 && carry > 0);
    }

    private void IncrementRight(int[] nums, int right, int carry)
    {
        do
        {
            int number = nums[right] + 1;
            nums[right] = number % 10;
            carry = number / 10;
            right++;
        } while (right < nums.Length && carry > 0);
    }

    private bool isPalindrome(int[] nums)
    {
        int start = 0;
        int end = nums.Length - 1;
        while (start < end)
        {
            if (nums[start] != nums[end])
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }

    private bool isAll9(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 9)
            {
                return false;
            }
        }

        return true;
    }
}