using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class StockSpan1
    {
        public int[] find(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return nums;
            }

            int[] result = new int[nums.Length];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i<nums.Length;i++)
            {
                while (stack.Count > 0 && nums[stack.Peek()] <= nums[i])
                { 
                    stack.Pop();
                }
                if (stack.Count > 0)
                {
                    result[i] = i-stack.Peek();
                }
                else
                {
                    result[i] = 1;
                }
                stack.Push(i);
            }

            return result;
        }
    }


}
