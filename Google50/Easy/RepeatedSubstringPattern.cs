using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Easy
{
    internal class RepeatedSubstringPattern
    {
        public bool find(string s)
        {
            if (s == null || s.Length <= 1)
            {
                return true;
            }
            int start = 0;
            int end = s.Length/2;
            while (start < end)
            {
                int range = end - start;
                while (s.Length % range != 0)
                {
                    end--;
                    range = end - start;
                }

                int repeat = s.Length / range;
                string subString = s.Substring(0, range);
                string result = string.Empty;
                for (int i = 0; i < repeat; i++)
                { 
                    result += subString;
                }

                if (result.Equals(s))
                {
                    return true;
                }
                end--;
            }

            return false;
        }
    }
}
