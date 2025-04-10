using System;

namespace Meta.Trees.PracticeDFS;

public class CountPathsforaSum
{
    // challenge is path can be start from any location
    // hint is path always will be from top to bottom

    // reduce the sum while going down => sum = sum-root.Val
    // if any place Sum becomes zero count one path
    // looks like every node will have a choice to take it or not take it

  public TreeNode PrepreTree()
    {
        TreeNode node = new TreeNode(12);
        node.Left = new TreeNode(7);
        node.Right = new TreeNode(1);
        node.Left.Left = new TreeNode(4);

        node.Right.Left = new TreeNode(10);
        node.Right.Right = new TreeNode(5);
        return node;
    }

    public int solve(TreeNode root,int sum, List<int> cp)
    {
        if(root==null)
        {
            return 0;
        }

        cp.Add(root.Val); //[12,7,4]
        int rs = 0;
        int paths =0;

        //count path
        for(int i = cp.Count-1;i>=0;i--) //0 -> 0
        {
                rs+=cp[i];
                if(rs==sum)
                {
                    paths++;
                }
        }

        paths+=solve(root.Left,sum,cp);
        paths+=solve(root.Right,sum,cp);
        cp.RemoveAt(cp.Count-1); //[12]
        return paths;
    }


}
