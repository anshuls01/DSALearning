using System.Data;
using System.Text;

namespace KElementPattern;

public class ReArrangeString
{
    //Design Guru solution
    public string Solution_DesignGuru(string str)
    {
        Dictionary<char, int> charFrequencyMap = createMap(str);

        var maxHeap = new SortedDictionary<int, List<char>>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        foreach (var entry in charFrequencyMap)
        {
            if (!maxHeap.ContainsKey(entry.Value))
                maxHeap[entry.Value] = new List<char>();

            maxHeap[entry.Value].Add(entry.Key);
        }

        KeyValuePair<char, int>? previousEntry = null;
        StringBuilder resultString = new StringBuilder(str.Length);
        while (maxHeap.Count > 0)
        {
            var currentEntry = maxHeap.First().Value;
            char currentChar = currentEntry[0];

            // add the previous entry back in the heap if its frequency is greater than zero
            if (previousEntry.HasValue && previousEntry.Value.Value > 0)
            {
                if (!maxHeap.ContainsKey(previousEntry.Value.Value))
                    maxHeap[previousEntry.Value.Value] = new List<char>();

                maxHeap[previousEntry.Value.Value].Add(previousEntry.Value.Key);
            }

            // append the current character to the result string and decrement its count
            resultString.Append(currentChar);

            // Decrement the count
            currentEntry.RemoveAt(0);
            if (currentEntry.Count == 0)
                maxHeap.Remove(maxHeap.First().Key);

            charFrequencyMap[currentChar]--;

            if (charFrequencyMap[currentChar] > 0)
                previousEntry = new KeyValuePair<char, int>(currentChar, charFrequencyMap[currentChar]);
            else
                previousEntry = null;
        }

        // if we were successful in appending all the characters to the result string, 
        // return it
        return resultString.Length == str.Length ? resultString.ToString() : "";
    }

    private Dictionary<char, int> createMap(string str)
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
    // public static void Main(string[] args)
    // {
    //     Solution solution = new Solution();
    //     Console.WriteLine("Rearranged string: " + solution.rearrangeString("aappp"));
    //     Console.WriteLine("Rearranged string: " + solution.rearrangeString("Programming"));
    // }
    private PriorityQueue<char, int> InitializePriorityQueue(Dictionary<char, int> map)
    {
        PriorityQueue<char, int> pq = new PriorityQueue<char, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        foreach (char key in map.Keys)
        {
            pq.Enqueue(key,map[key]);
        }

        return pq;
    }

    private void removeCharFromMap(char c, Dictionary<char, int> map)
    {
        if (map.ContainsKey(c))
        {
            map[c]--;
            if (map[c] == 0)
            {
                map.Remove(c);
            }
        }
    }

    public string solution_pq(string str)
    {
        if(string.IsNullOrEmpty(str) || str.Length==1)
        {
            return str;
        }

        StringBuilder sb = new StringBuilder();
        
        //create a map
        Dictionary<char, int> map = createMap(str);

        //create a max heap
        PriorityQueue<char, int> pq = InitializePriorityQueue(map);
        char? previous = null;
        while (pq.Count > 0)
        {
            char current = pq.Dequeue();
            removeCharFromMap(current, map);
            sb.Append(current);
            
            if (previous.HasValue && map.ContainsKey(previous.Value))
            {
                pq.Enqueue(previous.Value,map[previous.Value]);
            }

            if (map.ContainsKey(current) && map[current] > 0)
            {
                previous = current;
            }
            else
            {
                previous = null;
            }
        }

        return sb.ToString().Length == str.Length ? sb.ToString() : "";
    }
}