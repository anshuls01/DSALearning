using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class MinimizArrayReplacePairsWithTheirProduct
    {
        public int find(int[] nums, int k)
        { 
            List<int> list = new List<int>();
            foreach (int n in nums)
            {
                if (n == 0)
                {
                    return 1; // because all elements product will become zero
                }

                if (list.Count > 0 && list[list.Count - 1] * n <= k)
                {
                    list[list.Count - 1] *= n;
                }
                else
                { 
                    list.Add(n);
                }
            }
            return list.Count;
        }
    }
}
