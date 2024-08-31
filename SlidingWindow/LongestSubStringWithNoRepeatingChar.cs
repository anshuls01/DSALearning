namespace SlidingWindow;

public class LongestSubStringWithNoRepeatingChar
{
    public int find(string str)
    {
        int maxLength = 0;
        if (str == null || str.Length == 0)
        {
            return maxLength;
        }

        Dictionary<char, int> map = new Dictionary<char, int>();
        int start = 0;
        int end = 0;
        
        while (end < str.Length)
        {
            addCurrentCharToMap(map, str[end]);
            if (map.Keys.Count == (end - start + 1))
            {
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            if (map.Keys.Count < (end - start + 1))
            {
                while (map.Keys.Count < (end - start + 1))
                {
                    map[str[start]]--;
                    if (map[str[start]] == 0)
                    {
                        map.Remove(str[start]);
                    }
                    start++;

                }
            }

            end++;
        }

        return maxLength;
    }

    private void addCurrentCharToMap(Dictionary<char, int> map, char c)
    {
        if (!map.ContainsKey(c))
        {
            map[c] = 0;
        }

        map[c]++;
    }
}