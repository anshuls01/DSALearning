using System.Text;
namespace KElementPattern;

public class FrequencySort
{
    public string Solution(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return "";
        }

        Dictionary<char, int> freq = getFrequencyMap(str);
        PriorityQueue<char, int> pq = new PriorityQueue<char, int>(Comparer<int>.Create((a,b)=>b.CompareTo(a)));

        foreach (char c in freq.Keys)
        {
            pq.Enqueue(c,freq[c]);
        }

        StringBuilder sb = new StringBuilder();
        while (pq.Count > 0)
        {
            char c = pq.Dequeue();
            int count = freq[c];
            while (count > 0)
            {
                sb.Append(c);
                count--;
            }
        }

        return sb.ToString();
    }

    private Dictionary<char, int> getFrequencyMap(string str)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (char c in str)
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