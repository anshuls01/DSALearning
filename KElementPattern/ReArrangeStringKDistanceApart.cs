using System.Text;

namespace KElementPattern;

public class ReArrangeStringKDistanceApart
{
    public string find(string str, int k)
    {
        if(string.IsNullOrEmpty(str) || str.Length<=1)
        {
            return str;
        }

        Dictionary<char,int> map = createMap(str);
        if(map.Keys.Count==1)
        {
            if(map.First().Value>1 && k>1)
            {
                return "";
            }
        }
        PriorityQueue<char,int> pq = initializePriorityQueue(map);

        Queue<char> queue = new Queue<char>();
        StringBuilder sb = new StringBuilder();
        while(pq.Count>0)
        {
            char current = pq.Dequeue(); 
            adjustMapFrequency(current,map); 
            queue.Enqueue(current); 
            sb.Append(current); 

            if(queue.Count==k)
            {
                char previous = queue.Dequeue();  
                if(map.ContainsKey(previous) && map[previous]>0)
                {
                    pq.Enqueue(previous, map[previous]); 
                }
            }
        }

        string result = sb.ToString();
        return result.Length==str.Length?result:"";
    }
// base to handle if only one key is present

    private Dictionary<char,int> createMap(string str)
    {
        Dictionary<char,int> map = new Dictionary<char,int>();
        foreach(char c in str)
        {
            if(!map.ContainsKey(c))
            {
                map[c] = 0;
            }
            map[c]++;
        }

        return map;
    }

    private PriorityQueue<char,int> initializePriorityQueue(Dictionary<char,int> map)
    {
        PriorityQueue<char,int> pq = new PriorityQueue<char,int>(Comparer<int>.Create((a,b)=>b.CompareTo(a)));

        foreach(char key in map.Keys)
        {
            pq.Enqueue(key, map[key]);
        }
        return pq;
    }
    private void adjustMapFrequency(char c, Dictionary<char,int> map)
    {
        if(map.ContainsKey(c))
        {
            map[c]--;
            if(map[c]==0)
            {
                map.Remove(c);
            }
        }
    }

}