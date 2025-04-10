using System;
using System.Diagnostics.Contracts;

namespace Meta.Trees.PracticeDFS;

public class PathExists
{
    // need to keep a counter to know, how many items match, if no match keep early return
    // if few match and mismatch occured for other items, just track back

    // root to leaf -> i.e. if root item is not equal to first item in array return
    // i.e. == root.Val !=items[i]  -> false
    // root.Val == items ->continue, if root is leaf return true
    // path can be exist in left or right sub tree
    // t: O(n), s: O(n)

    public bool isValid(TreeNode root, int[] nums, int i=0)
    {
        if(root==null || i>=nums.Length)
        {
            return false;
        }

        if(root.Val!=nums[i])
        {
            return false;
        }

        if(root.Left==null && root.Right==null && i==nums.Length-1)
        {
            return true;
        }

        bool leftResult = isValid(root.Left,nums, i+1);
        bool rightResult = isValid(root.Right,nums, i+1);

        return leftResult||rightResult;
    }

}
