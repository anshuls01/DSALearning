namespace SlidingWindow;

public class findPermutation
{
    public bool find(string str, string pattern)
    {
        // TODO: Write your code here
        if (pattern.Length > str.Length)
        {
            return false;
        }

        Dictionary<char, int> freq = createMap(pattern);
        int count = freq.Keys.Count;
        int start = 0;
        int end = 0;
        while (end < str.Length)
        {
            if (!freq.ContainsKey(str[end]))
            {
                while (start != end)
                {
                    if (freq.ContainsKey(str[start]))
                    {
                        freq[str[start]]++;
                        if (freq[str[start]] == 1)
                        {
                            count++;
                        }
                    }

                    start++;
                }

                end++;
            }
            else
            {
                while (end < str.Length && freq.ContainsKey(str[end]))
                {
                    freq[str[end]]--;
                    if (freq[str[end]] == 0)
                    {
                        count--;
                    }

                    if (count == 0)
                    {
                        return true;
                    }

                    end++;
                }
            }
        }

        return count == 0;
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