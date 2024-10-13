using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Easy
{
    internal class SetMismatch
    {
        public int[] findPair(int[] nums)
        {

            int[] pair = null;
            //cyclic sort
            if (nums == null || nums.Length < 2)
            {
                return new int[] { 0, 0 };
            }
            int i = 0;
            while (i < nums.Length)
            {
                while (nums[i] != i + 1 && nums[nums[i] - 1] != nums[i]) 
                {
                    /*  0   1   2   3
                     *  1   3   3   4
                     *  
                     *  0 1 2 3 4 5 6
                    // [1,5,3,2,7,7,6]
                    // [1,7,3,2,5,6,7]
                    */
                    swap(nums[i]-1, i,nums);
                }
                i++;
            }
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != j + 1)
                {
                    pair = new int[] { nums[j], j + 1 };
                }
            }
            return pair;
        }

        private void swap(int a, int b, int[] nums)
        { 
            int temp = nums[a];
            nums[a]  = nums[b];
            nums[b] = temp;
        }
    }
}
