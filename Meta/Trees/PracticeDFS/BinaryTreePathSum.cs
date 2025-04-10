using System;

namespace Meta.Trees.PracticeDFS;

public class BinaryTreePathSum
{
    public bool SumExist(TreeNode root, int sum)
    {
        if(root==null)
        {
            return false;
        }

        if(root.Left==null && root.Right==null && sum==root.Val)
        {
            return true;
        }
       return  SumExist(root.Left,  sum-root.Val)|| SumExist(root.Right,sum-root.Val);
    }

}
