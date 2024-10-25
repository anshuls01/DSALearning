using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class ArithmeticSlices
    {
        public int findCount(int[] nums)
        {
            if (nums.Length < 3) return 0;

            int count = 0;
            int tc = 0;
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] - nums[i - 1] == nums[i + 1] - nums[i])
                {
                    count++;
                    tc += count; // ye pattern kahi to dekha hain

                }
                else
                {
                    count = 0;
                }
            }
            return tc;
        }
    }
}
