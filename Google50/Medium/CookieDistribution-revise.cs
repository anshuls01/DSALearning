using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class CookieDistribution_revise
    {
        public int find(int[] cookies, int c)
        {
            if (cookies == null)
            {
                return 0;
            }
            //if (cookies.Length == c)
            //{
            //    return cookies.Max();
            //}

            int minValue = int.MaxValue;
            int[] cd = new int[c];
            minValue = backtrack(cookies, minValue,0,cd);
            return minValue;
        }

        private int backtrack(int[] cookies, int minValue, int index,  int[] cd)
        {
            if (index == cookies.Length)
            { 
                minValue = Math.Min(cd.Max(),minValue);
                return minValue;
            }

            int currentMin = minValue;
            for (int i = 0; i < cd.Length; i++)
            {
                cd[i] += cookies[index];
                currentMin = backtrack(cookies, currentMin, index + 1, cd);
                cd[i] -= cookies[index];
            }

            return currentMin;
        }
    }
}
