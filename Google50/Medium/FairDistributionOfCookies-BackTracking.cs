using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class FairDistributionOfCookies_BackTracking
    {
        //cookies length: c
        //t: c*k^c
        //s: k
        public int find(int[] cookies, int k)
        {
            if (cookies == null || cookies.Length == 0 || k == 0)
            {
                return 0;
            }

            if (k == cookies.Length)
            {
                return cookies.Max();
            }
            return backtrack(cookies, new int[k], 0, int.MaxValue);
        }

        private int backtrack(int[] cookies, int[] children, int index, int min)
        {
            if (index == cookies.Length)
            {
                min = Math.Min(min, children.Max());
                return min;
            }

            int minUnfairness = min;
            for (int i = 0; i < children.Length; i++)
            {
                children[i] += cookies[index];
                minUnfairness = backtrack(cookies, children, index + 1, minUnfairness);
                children[i]-=cookies[index];
            }

            return minUnfairness;
        }
    }
}
