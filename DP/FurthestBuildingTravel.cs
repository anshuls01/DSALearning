using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    internal class FurthestBuildingTravel
    {
        //definatly or condition will come
        public int find(int[] nums, int bricks, int ladder, int i = 1)
        {
            // base case if(bricks)
            if (i == nums.Length)
            {
                return i;
            }
            if (bricks <= 0 || ladder<=0)
            {
                return i;
            }

            
            if (i > 0 && nums[i - 1] >= nums[i])
            {
                 find(nums, bricks, ladder, i + 1);
            }

            int brickDistance = 0;
            if (nums[i] < bricks)
            {
                int remainig = bricks - nums[i];
                brickDistance = find(nums, remainig, ladder, i + 1);
            }

            int ladderDistance = 0;
            if (ladder > 0)
            {
                ladderDistance = find(nums, bricks, ladder - 1, i + 1);
            }
            return Math.Max(Math.Max(brickDistance, ladderDistance),i);
        }
    }
}
