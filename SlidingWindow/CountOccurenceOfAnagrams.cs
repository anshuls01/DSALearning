namespace SlidingWindow;

public class CountOccurenceOfAnagrams
{
    public int Solution(string str, string pattern)
    {
        int count = 0;
        if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(str))
        {
            return count;
        }

        if (pattern.Length > str.Length)
        {
            return count;
        }

        Dictionary<char, int> freq = getFrequencyMap(pattern);
        int length = pattern.Length;
        int start = 0;
        int end = 0;
        int valuesCount = freq.Keys.Count;
        while (end < str.Length)
        {
            //checkCharFreqInMap(freq, str[end]);
            if (freq.ContainsKey(str[end]))
            {
                freq[str[end]]--;
                if (freq[str[end]] == 0)
                {
                    valuesCount--;
                }
            }

            if (end - start + 1 == length)
            {
                //find answer
                if (valuesCount == 0)
                {
                    count++;
                }
                
                if (freq.ContainsKey(str[start]))
                {
                    freq[str[start]]++;
                    if (freq[str[start]] == 1)
                    {
                        valuesCount++;
                    }
                }
                start++;
            }

            
            end++;
        }

        return count;
    }

    private Dictionary<char, int> getFrequencyMap(string pattern)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (char c in pattern.ToCharArray())
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