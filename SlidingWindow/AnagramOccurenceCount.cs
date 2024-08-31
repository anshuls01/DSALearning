namespace SlidingWindow;

public class AnagramOccurenceCount
{
    public int find(string str, string pattern)
    {
        int count = 0;
        if (str == null || str.Length == 0 || str.Length<pattern.Length)
        {
            return count;
        }

        Dictionary<char, int> map = createMap(pattern);

        int k = pattern.Length;
        int start = 0;
        int end = 0;
        int match = map.Keys.Count;
        int i = 0;
        while (end < str.Length)
        {
            if (map.ContainsKey(str[end]))
            {
                map[str[end]]--;
                if (map[str[end]] == 0)
                {
                    match--;
                }
            }

            if (k == end - start + 1)
            {
                if (match == 0)
                {
                    count++;
                }

                if (map.ContainsKey(str[start]))
                {
                    map[str[start]]++;
                    if (map[str[start]] == 1)
                    {
                        match++;
                    }
                }

                start++;
            }
            end++;

        }

        return count;
    }

    private Dictionary<char, int> createMap(string pattern)
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