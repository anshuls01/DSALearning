namespace SlidingWindow;

public class VLongestSubStringWithUniqueKChar
{
    public int Solution(string str, int k)
    {
        if (string.IsNullOrEmpty(str) || str.Length < k)
        {
            return -1;
        }

        Dictionary<char, int> map = new Dictionary<char, int>(); //aabacbebebe
        int start = 0;
        int end = 0;
        int maxLength = int.MinValue;
        int uniqueMapKeys = 0;
        while (end < str.Length)
        {
            if (!map.ContainsKey(str[end]))
            {
                map[str[end]] = 0;
            }

            map[str[end]]++;
            if (map[str[end]] == 1)
            {
                uniqueMapKeys++;
            }


            if (uniqueMapKeys >= k)
            {
                if (uniqueMapKeys == k)
                {
                    maxLength = Math.Max(maxLength, map.Values.Sum());
                }

                while (uniqueMapKeys > k)
                {
                    map[str[start]]--;
                    if (map[str[start]] == 0)
                    {
                        uniqueMapKeys--;
                    }

                    start++;
                }
            }

            end++;
        }

        return maxLength;
    }
}