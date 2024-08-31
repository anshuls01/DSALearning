namespace SlidingWindow;

public class MinimumWindowSubsrting
{
    public int find(string str, string pattern)
    {
        int minValue = int.MaxValue; 
        if (str == null || str.Length == 0 || str.Length < pattern.Length)
        {
            return 0;
        }

        Dictionary<char, int> map = GetMap(pattern);
        int start = 0;
        int end = 0;
        int count = map.Keys.Count;
        while (end < str.Length)
        {
            if (map.ContainsKey(str[end]))
            {
                map[str[end]]--;

                if (map[str[end]] == 0)
                {
                    count--;
                }
            }

            if (count == 0)
            {
                while (count == 0)
                {
                    if (map.ContainsKey(str[start]))
                    {
                        map[str[start]]++;
                        if (map[str[start]] == 1)
                        {
                            count++;
                        }
                    }
                    minValue = Math.Min(minValue, end - start + 1);
                    start++;
                }
            }

            end++;
        }

        return minValue == int.MaxValue ? 0 : minValue;
    }

    private Dictionary<char, int> GetMap(string pattern)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (char c in pattern)
        {
            if (!map.ContainsKey(c))
            {
                map[c] = 0;
            }

            map[c]++;
        }

        return map;
    }
}