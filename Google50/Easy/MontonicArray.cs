using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Easy
{
    internal class MontonicArray
    {
        public bool find(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return true;
            }

            bool isIncreasing = true;
            bool isDecreasing = true;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    isDecreasing = false;
                }
                if (nums[i] < nums[i + 1])
                {
                    isIncreasing = false;
                }
            }
            return isIncreasing || isDecreasing;
        }

        public bool find1(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return true;
            }

            bool isIncreasing = false;
            bool isDecreasing = false;

            if (nums[0] < nums[nums.Length - 1])
            {
                isIncreasing = true;
            }
            else
            {
                isDecreasing = true;
            }

            bool result = false;
            if (isIncreasing)
            {
                result = checkforIncreasing(nums);
            }
            if (isDecreasing)
            {
                result = checkforDecreasing(nums);
            }
            return result;
        }

        private bool checkforDecreasing(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (!(nums[i] >= nums[i + 1]))
                { 
                    return false;
                }
            }
            return true;
        }

        private bool checkforIncreasing(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (!(nums[i] <= nums[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
