namespace TwoPointers;

public class SquaringASortedArray
{
    public int[]? solution(int[]? numbers)
    {
        if (numbers == null)
        {
            return null;
        }

        if (numbers.Length < 2)
        {
            return numbers;
        }

        int[] result = new int[numbers.Length];
        int start = 0;
        int end = numbers.Length - 1;
        int index = numbers.Length - 1;
        while (start < end)
        {
            int num1 = Math.Abs(numbers[start]);
            int num2 = Math.Abs(numbers[end]);
            if (num1>num2)
            {
                result[index] = num1*num1;
                start++;
            }
            else
            {
                result[index] = num2*num2;
                end--;
            }

            index--;
        }

        return result;
    }
}