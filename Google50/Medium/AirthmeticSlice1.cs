using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class AirthmeticSlice1
    {
        // 1 3 5 7 9 10 11
        // 0 1 2 3 4 5  6
        public int find(int[] nums)
        {
            int count = 0;
            int progress = 0;
            int total = 0;
            int i = 1;
            while (i < nums.Length)
            { 
                int diff = nums[i]-nums[i - 1];//1
                while (i<nums.Length && nums[i] - nums[i - 1] == diff)
                {
                    if (count < 2)
                    {
                        count++;//2
                    }
                    if (count == 2)
                    { 
                        progress++;//1
                        total += progress;//1 + 2 + 3 + 1
                    }
                    i++;
                }
                count = 0;
                progress = 0;
            }
            return total;
        }
    }
}
