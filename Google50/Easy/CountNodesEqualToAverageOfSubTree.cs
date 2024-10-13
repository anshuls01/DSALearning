using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Easy
{
    internal class CountNodesEqualToAverageOfSubTree
    {
        public int find(TreeNode root)
        {
            AvgNodeCount avgNodeCount = findCount(root);
            return avgNodeCount.found;
        }

        private AvgNodeCount findCount(TreeNode root)
        {
            if (root == null)
            {
                return new AvgNodeCount(0, 0,0);
            }
            if (root.Left == null && root.Right == null)
            {
                return new AvgNodeCount(root.Val, 1,1);
            }

            AvgNodeCount left = findCount(root.Left);
            AvgNodeCount right = findCount(root.Right);

            int divisor = left.Count + right.Count + 1;
            int sum = root.Val + left.Sum + right.Sum;
            int totalFound = left.found + right.found;
            AvgNodeCount avgNodeCount = new AvgNodeCount(sum, divisor, totalFound);
            if (sum/divisor == root.Val)
            { 
                avgNodeCount.found++;
            }

            return avgNodeCount;
        }

        public TreeNode BuildTree()
        {
            //TreeNode a = new TreeNode(3);
            //TreeNode b = new TreeNode(1);
            //TreeNode c = new TreeNode(4);
            //TreeNode d = new TreeNode(2);
            ////TreeNode e = new TreeNode(3);
            //a.Left = b;
            //a.Right = c;
            //b.Right = d;

            //TreeNode a = new TreeNode(5);
            //TreeNode b = new TreeNode(4);
            //TreeNode c = new TreeNode(8);
            //TreeNode d = new TreeNode(3);
            //TreeNode e = new TreeNode(6);
            //TreeNode f = new TreeNode(7);
            //a.Left = b;
            //a.Right = c;
            //b.Left = d;
            //c.Left = e;
            //c.Right = f;

            TreeNode a = new TreeNode(10);
            TreeNode b = new TreeNode(20);
            TreeNode c = new TreeNode(30);
            TreeNode d = new TreeNode(40);
            TreeNode e = new TreeNode(50);
            TreeNode f = new TreeNode(60);
            TreeNode g = new TreeNode(70);
            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Left = f;
            c.Right = g;

            return a;
        }

        public class AvgNodeCount { 
            public int Count;
            public int Sum;
            public int found;
            public AvgNodeCount(int sum, int count,int found)
            {
                this.Sum = sum;
                this.Count = count;
                this.found = found;
            }
        }
    }
}
