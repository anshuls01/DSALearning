using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Easy
{
    internal class IsSubSequence
    {

        public bool find(string s, string t)
        {
            if (s == null || t == null || s.Length > t.Length)
            {
                return false;
            }

            int si = 0; //s index

            for (int ti = 0; ti < t.Length && si<s.Length; ti++)
            {
                if (s[si] == t[ti])
                {
                    si++;
                }
            }
            return si == s.Length;
        }
        // how stupid solution -> why to use sliding window
        public bool find1(string s, string t)
        {
            /*
             * "abc", 0 0 1  1 
             * "aabc"
             */
            if (s == null || t == null || s.Length > t.Length)
            {
                return false;
            }
            Dictionary<char, int> freq = createFreqMap(s);
            int charCount = 0;
            int i = 0; // for s length
            int j = 0;// for t length
            while (i<s.Length && j < t.Length)
            {
                
                if (s[i] == t[j])
                {
                    freq[s[i]]--;
                    if (freq[s[i]] == 0)
                    {
                        charCount++;
                    }
                    i++;
                }
                j++;
                if (charCount == freq.Count)
                {
                    return true;
                }
            }

            return false;
        }

        private Dictionary<char, int> createFreqMap(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in s)
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
}
