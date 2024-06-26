namespace SlidingWindow;

public class VPickUniqueToys
{
    public int Solution(char[]? chars, int k)
    {
        if (chars == null || chars.Length == 0)
        {
            return - 1;
        }

        int maxToys = -1;
        int start = 0;
        int end = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        while (end < chars.Length)
        {
            char current = chars[end];
            if (!map.ContainsKey(current))
            {
                map[current] = 0;
            }

            map[current]++;
            if (map.Keys.Count >= k)
            {
                if (map.Keys.Count == k)
                {
                    maxToys = Math.Max(maxToys, map.Values.Sum());
                }

                while (map.Keys.Count > k)
                {
                    map[chars[start]]--;
                    if (map[chars[start]] == 0)
                    {
                        map.Remove(chars[start]);
                    }
                    start++;
                }
            }

            end++;
        }

        return maxToys;
    }
}