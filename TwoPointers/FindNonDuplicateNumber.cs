using System.Globalization;

namespace TwoPointers;

public class FindNonDuplicateNumber
{
    public int MoveNumbers(int[]? numbers)
    {
        if (numbers == null || numbers.Length <2)
        {
            return 0;
        }

        int start = 0;
        int next = 0;
        while (next < numbers.Length)
        {
            if (numbers[start] == numbers[next])
            {
                next++;
            }
            else
            {
                start++;
                numbers[start] = numbers[next];
                next++;
            }
        }
        printNumbers(numbers);
        return start+1;
    }

    private void printNumbers(int[] numbers)
    {
        Console.WriteLine(string.Join(",",numbers));
    }
}