using System;
using System.Security.Cryptography.X509Certificates;

namespace Meta.Trees.PracticeDFS;

public class CountPathForASum_ON
{
    public int solve(TreeNode root, int ts)
    {
     
        Dictionary<int,int> map = new Dictionary<int, int>();
        return find(root, ts, map, 0);
    }

    private int find(TreeNode root, int ts, Dictionary<int,int> map, int cps)
    {
        if(root==null)
        {
            return 0;
        }
        int pathcount = 0;
        cps+=root.Val;

        if(ts==cps)
        {
            pathcount++;
        }
        //if any previous exist
        if (map.ContainsKey(cps-ts))
        {
            pathcount+=map[cps-ts];
        }
//maintan current entry
        if(!map.ContainsKey(cps))
        {
            map[cps] = 0;
        }
        map[cps]++;

        pathcount+=find(root.Left,ts,map,cps);
        pathcount+=find(root.Right,ts,map,cps);

        map[cps]--;//remove
        return pathcount;
    }
}
