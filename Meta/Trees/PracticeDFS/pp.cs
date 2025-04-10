using System;
using System.Runtime.InteropServices;

namespace Meta.Trees.PracticeDFS;

public class pp
{
    public int solve(TreeNode root,int sum)
    {
        if(root==null )
        {
            return 0;
        }
        return find(root, sum, new List<int>());
    }

// t:O(n^2) s:O(n)
    private int find(TreeNode root, int sum,  List<int> cp)
    {
        if(root==null)
        {
            return 0;
        }
        cp.Add(root.Val);
        int rs = 0;
        int pathcount = 0;
        foreach(int i in cp)
        {
            rs+=i;
            if(i==sum)
            {
                pathcount++;
            }
        }

        pathcount+=find(root.Left, sum, cp);
        pathcount+=find(root.Right, sum, cp);
        cp.RemoveAt(cp.Count-1);
        return pathcount;
    }

    
}
