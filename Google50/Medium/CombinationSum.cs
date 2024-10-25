using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class CombinationSum
    {
        public List<List<int>> find(int[] nums, int target)
        { 
            List<List<int>> result = new List<List<int>>();
            if (nums == null || nums.Length == 0)
            {
                return result;
            }

            //all combination
            //result = getCombination(nums, target);
            

            // unique ways
            getCombinationBT(nums, target,0, result, new List<int>());
            return result;

        }

        // it return all combination but not the unique combination -> looks similar to coin change
        private List<List<int>> getCombination(int[] nums, int target)
        {
            if (target < 0)
            {
                return null;
            }

            if (target == 0)
            { 
                //found 1 // add the result bottom up
                return new List<List<int>> { new List<int>() };
            }

            List<List<int>> AllWays = new List<List<int>>();
            foreach (int num in nums)
            {
                int reminder = target - num;
                List<List<int>> combinationWays =  getCombination(nums, reminder);
                if (combinationWays != null)
                {
                    foreach (List<int> combination in combinationWays)
                    { 
                        List<int> way = new List<int>(combination);
                        way.Add(num);
                        AllWays.Add(way);
                    }
                }
            }
            return AllWays;
        }


        // trying with backtracking
        private void getCombinationBT(int[] nums, int target,int start, List<List<int>> AllWays, List<int> ways)
        {
            if (target == 0)
            {
                //found 1 // add the result bottom up
                AllWays.Add(new List<int>(ways) );
                return;
            }


            for (int i= start; i < nums.Length;i++)
            {
                if (target < nums[i])
                {
                    continue;
                }
                int reminder = target - nums[i];
                ways.Add(nums[i]);
                getCombinationBT(nums, reminder,i, AllWays, ways);
                ways.RemoveAt(ways.Count-1);
              
            }
        }
    }
}
