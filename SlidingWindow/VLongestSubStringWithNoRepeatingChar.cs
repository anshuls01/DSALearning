namespace SlidingWindow;

public class VLongestSubStringWithNoRepeatingChar
{
    public int Solution(string str)
    {
        //longest string with no repeating char
        if (string.IsNullOrEmpty(str))
        {
            return -1;
        }

        int maxLength = -1;
        int start = 0;
        int end = 0;
        // if found any repeating char than have to remove all the char till end and set the start and end pointer
        // below approach shouldn't give the right answer
        Dictionary<char, int> map = new Dictionary<char, int>();
        int uniqueKeys = 0;
        while (end < str.Length)
        {
            char current = str[end];
            if (!map.ContainsKey(current))
            {
                map[current] = 0;
            }

            map[current]++;
            if (map[current] == 1)
            {
                uniqueKeys++;
            }

            int currentSum = map.Values.Sum();
            if (currentSum >= uniqueKeys)
            {
                if (uniqueKeys == currentSum)
                {
                    maxLength = Math.Max(maxLength, uniqueKeys);
                }

                while (currentSum > uniqueKeys)
                {
                    map[str[start]]--;
                    currentSum--;
                    if (map[str[start]] == 0)
                    {
                        uniqueKeys--;
                    }

                    start++;
                }
            }

            end++;
        }

        // pwwkews  -> wke or kew


        return maxLength;
    }
}