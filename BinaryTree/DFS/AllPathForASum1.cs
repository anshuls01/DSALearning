using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.DFS
{
    internal class AllPathForASum1
    {
        public void Print(TreeNode root, int target)
        {

            List<List<int>> result = find(root, target);
            foreach (List<int> path in result)
            {
                Console.WriteLine(string.Join(",", path));
            }
        }

        public void Print_BackTracking(TreeNode root, int target)
        {
            if (root == null)
            {
                return;
            }
            List<List<int>> result = new List<List<int>>();
            List<int> path = new List<int>();
            find_backTracking(root, target, path, result);
            foreach (List<int> rpath in result)
            {
                Console.WriteLine(string.Join(",", rpath));
            }
        }

        private void find_backTracking(TreeNode root, int target, List<int> path, List<List<int>> result)
        {
            if (root == null)
            {
                return;
            }
            path.Add(root.Val);

            if (root.Left == null && root.Right == null && root.Val == target)
            {
                result.Add(new List<int>(path));
            }
            else
            {
                //path.Add(root.Val);
                find_backTracking(root.Left, target - root.Val, path, result);
                find_backTracking(root.Right, target - root.Val, path, result);
            }
            path.RemoveAt(path.Count - 1);

        }

        private List<List<int>> find(TreeNode root, int target)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Val == target && root.Left == null && root.Right == null)
            {
                return new List<List<int>> { new List<int> { root.Val } };
            }

            List<List<int>> AllPath = new List<List<int>>();
            List<List<int>> leftPath = find(root.Left, target - root.Val);
            if (leftPath != null)
            {
                foreach (List<int> lpath in leftPath)
                {
                    List<int> path = new List<int>(lpath);
                    path.Add(root.Val);
                    AllPath.Add(path);
                }

            }
            List<List<int>> rightPath = find(root.Right, target - root.Val);
            if (rightPath != null)
            {
                foreach (List<int> rpath in rightPath)
                {
                    List<int> path = new List<int>(rpath);
                    path.Add(root.Val);
                    AllPath.Add(path);

                }
            }
            return AllPath;
        }
    }
}
