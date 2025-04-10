using System;

namespace Meta.Strings;

public class ThreeSumNoSortHashSet
{
        
     

    public void solve(int[] nums)
    {
        Dictionary<int,int> map = new Dictionary<int, int>();
        HashSet<int> dset = new HashSet<int>();
        HashSet<List<int>> result = new HashSet<List<int>>();

        if(nums==null || nums.Length<3)
        {
            return;
        }

        for(int i = 0;i<nums.Length;i++)
        {
            if(dset.Add(nums[i]))
            {
                for(int j = i+1;j<nums.Length;j++)
                {
                    int comp = -nums[i]-nums[j];
                    if(map.ContainsKey(comp) && map[comp]==i)
                    {
                        int[] triplet = [nums[i], nums[j], comp];
                        Array.Sort(triplet);
                        result.Add(triplet.ToList());
                    }
                    else
                    {
                        map[nums[j]] = i;
                    }

                }
            }
        }
        foreach(List<int> values in result)
        {
            Console.WriteLine(string.Join(",", values));
        }
    }
}
