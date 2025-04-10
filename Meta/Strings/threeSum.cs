using System;
using System.Runtime.InteropServices;
using Meta.Graph.PracticeSimpleTraversal;

namespace Meta.Strings;

public class threeSum
{
    //return all triplets
    // can't have duplicate tripletes
    // i,j,k should refer different index position
    //  [-1,0,1,2,-1,-4]
    // [-1,0,1] [-1,2,-1], 
    //  num1 + num2 + num3 = 0
    //  num2 + num3 = -num1
    // if i sort the original array nlogn
    // [-4,-1,-1, 0, 1,2] -. if remove duplicate will really help or use two pointer to ignore duplicate
    // [-4,-1,-1, 0, 1,     2] 
    //         s  s1  e-1   e
    // [0,1,-1] not allowed, due to duplicate triplet -> if i can sort and add to hashset --> dicard this

    // [0,0,0]
    /*
     [-1,0,1,2,-1,-4]   -> [-1,0,1], [0,1,-1],[-1,-1,2]
     [-4,-1,-1,0,1,2] -> [-1,-1,2],[-1,0,1]
    */
public void findTriplet(int[] nums)
{
    List<int[]> result = new List<int[]>();
    if(nums==null || nums.Length<3)
    {
        return;
    }

    Array.Sort(nums);
    for(int i = 0;i<nums.Length-1&&nums[i]<=0;i++)
    {
        if(i==0 || nums[i]!=nums[i+1])
        {
            List<int[]>items =  find(nums, i, nums.Length-1, -nums[i]); //nums, 1,2,0
            foreach(int[] item in items)
            {
                    result.Add (new int[]{nums[i],item[0],item[1]});
            }
        }
    }
    
    foreach(int[] triplet in result)
    {
        Console.WriteLine(string.Join(",",triplet));
    }
}
    private List<int[]> find(int[] nums, int start, int end, int target)
    {
        List<int[]> items = new List<int[]>();
        while(start<end)
        {
            int ps = nums[start]+nums[end];
            if(ps==target)
                items.Add(new int[]{nums[start],nums[end]});

            if (ps>target)
            {
                end--;
            }
            else
            {
                start++;
            }
        }

        return items;
    }
}
