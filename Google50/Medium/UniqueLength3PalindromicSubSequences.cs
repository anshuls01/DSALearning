using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class UniqueLength3PalindromicSubSequences
    {
        public int find(string s)
        { 
            HashSet<string> set = new HashSet<string>();// because it's length 3 set, should be good enough to find unique in O(1)
            char c = 'a';
            while (c <= 'z')
            { 
                int first = s.IndexOf(c);
                int last = s.LastIndexOf(c);
                if (last - first > 1)
                {
                    for (int i = first + 1; i < last; i++)
                    { 
                        string pp = s[first].ToString() + s[i].ToString() + s[last].ToString();
                        set.Add(pp);
                    }
                }
                c++;
            }
            return set.Count;
        }
    }
}
