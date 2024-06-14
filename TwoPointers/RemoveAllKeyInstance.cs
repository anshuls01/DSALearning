namespace TwoPointers;

public class RemoveAllKeyInstance
{
    public int GetNonDuplicateArrayLength(int[]? numbers, int key)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;
        int start = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == key)
            {
                counter++;
            }
            else
            {
                numbers[start] = numbers[i];
                start++;
            }
        }

        Console.WriteLine(string.Join(",", numbers));
        return numbers.Length - counter;
    }
}