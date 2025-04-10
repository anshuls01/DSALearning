using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace Meta.Trees.PracticeDFS;

public class TreeDiameter
{
    private int maxDia;
    public int solve(TreeNode root)
    {
        if(root==null)
        {
            return 0;
        }
        maxDia = 0;
        find(root);
        return maxDia;
    }

    private int find(TreeNode root)
    {
        if(root==null){return 0;}

        
        int leftheight = find(root.Left);
        int rightheight = find(root.Right);
        if(leftheight!=0 && rightheight!=0)
        {
            int curentDia = 1 + leftheight + rightheight;
            maxDia = Math.Max(maxDia, curentDia);
        }

        return Math.Max(leftheight,rightheight) +1;
    }
}
