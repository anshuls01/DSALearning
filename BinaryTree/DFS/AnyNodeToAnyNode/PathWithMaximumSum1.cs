using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.DFS.AnyNodeToAnyNode
{
    internal class PathWithMaximumSum1
    {
        public int MaxSum = int.MinValue;
        List<List<int>> MaxSumPath = new List<List<int>>();
        public void findPathWithMaxSum(TreeNode root)
        {
            findMaxSum(root);
            Console.WriteLine(MaxSum);
            MaxSum = int.MinValue;
            find(root);
            if (MaxSumPath != null)
            {
                Console.WriteLine(string.Join(",", MaxSumPath[0]));
            }
            Console.WriteLine(MaxSum);
        }

        private int findMaxSum(TreeNode root)
        {
            if (root == null)
            {
                return int.MinValue; // to handle -ve number
            }

            //List<int> path = new List<int>();
            int leftPath = findMaxSum(root.Left);
            int rightPath = findMaxSum(root.Right);
            leftPath = Math.Max(leftPath, 0);
            rightPath = Math.Max(rightPath, 0);

            int currentSum = leftPath + rightPath + root.Val;
            MaxSum = Math.Max(currentSum, MaxSum);
            return Math.Max(leftPath, rightPath) + root.Val;
        }
        private List<int> find(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            List<int> leftPath = find(root.Left);
            List<int> rightPath = find(root.Right);
            int leftSum = 0;
            if (leftPath.Count > 0)
            {
                leftSum = Math.Max(leftPath.Sum(),0);
            }
            int rightSum = 0;
            if (rightPath.Count > 0)
            {
                rightSum = Math.Max(rightPath.Sum(),0);
            }

            int currentSum = root.Val + leftSum + rightSum;
            if (currentSum > MaxSum)
            {
                MaxSum = currentSum;
                if (MaxSumPath.Count > 0)
                {
                    MaxSumPath.RemoveAt(MaxSumPath.Count - 1);
                }
                List<int> currentPath = new List<int>();
                if (leftSum > 0)
                    currentPath.AddRange(leftPath);

                currentPath.Add(root.Val);

                if (rightSum > 0)
                    currentPath.AddRange(rightPath);

                MaxSumPath.Add(currentPath);

            }
            List<int> path = new List<int>();
            if (leftSum > rightSum)
            {
                path = leftPath;
            }
            else
            {
                path =rightPath;
            }
            path.Add(root.Val);
            return path;


        }
    }
}
