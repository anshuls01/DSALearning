using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class MaxAreaHistogram1
    {
        public int find(int[] heights)
        {
            int maxArea = int.MinValue;
            if (heights == null || heights.Length == 0)
            { 
                return 0;
            }

            int[] NSR = findNSR(heights);
            int[] NSL = findNSL(heights);

            for (int i = 0; i < heights.Length; i++)
            {
                int area = (Math.Abs(NSR[i] - NSL[i]) - 1) * heights[i];
                maxArea = Math.Max(maxArea, area);
            }

            return maxArea;
        }

        private int[] findNSL(int[] heights)
        {
            int[] result = new int[heights.Length];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i< heights.Length; i++)
            {
                while (stack.Count > 0 && heights[stack.Peek()] > heights[i])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    result[i] = -1;
                }
                else
                {
                    result[i] = stack.Peek();
                }
                stack.Push(i);
            }
            return result;
        }

        private int[] findNSR(int[] heights)
        {
            int[] result = new int[heights.Length];
            Stack<int> stack = new Stack<int>();
            
            for (int i = heights.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && heights[stack.Peek()] > heights[i])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    result[i] = heights.Length;
                }
                else {
                    result[i] = stack.Peek();
                }
                stack.Push(i);
            }
            return result;
        }
    }
}
