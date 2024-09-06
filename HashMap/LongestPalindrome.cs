namespace HashMap;

public class LongestPalindrome
{
    public int find(string s) {
        int length = 0;
        // ToDo: Write Your Code Here.
        Dictionary<char,int> map = CreateFreqMap(s);
        bool alredyTaken = false;
        foreach(char c in map.Keys)
        {
            length += (map[c]/2)*2;
            map[c] %= 2;
            if(!alredyTaken)
            {
                if(map[c]==1)
                {
                    length++;
                    alredyTaken=true;
                }
            }
        }

        
        return length;
    }

    private Dictionary<char,int> CreateFreqMap(string s)
    {
        Dictionary<char,int> map = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if(!map.ContainsKey(c))
            {
                map[c] = 0;
            }
            map[c]++;
        }
        return map;
    }
}