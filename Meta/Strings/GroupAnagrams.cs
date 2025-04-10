using System;
using System.Text;

namespace Meta.Strings;

public class GroupAnagrams
{
    public IList<IList<string>> solve (string[] words)
    {
        IList<IList<string>> result = new List<IList<string>>();
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        foreach(string word in words)
        {
            int[] key = new int[128];
            foreach(char c in word)
            {
                key[c-'a'] += 1;
            }
            StringBuilder sb = new StringBuilder();
            foreach(int i in key)
            {
                sb.Append(i);
                sb.Append("$");

            }
            string keyStr = sb.ToString();
            if(!map.ContainsKey(keyStr))
            {
                map[keyStr].Add(word);
            }
        }
        foreach(var list in map.Values)
        {
            result.Add(list);
        }
        return result;   
    }
}
