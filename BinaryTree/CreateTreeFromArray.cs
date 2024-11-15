using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class CreateTreeFromArray
    {
        public void BuildTree(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return;
            }

            TreeNode dfsTree = BuildTree_Dfs(nums, 0);
            PrintTree(dfsTree);
            Console.WriteLine(" ");
            TreeNode bfsTree = BuildTree_Bfs(nums);
            PrintTree(bfsTree);
        }
        private TreeNode BuildTree_Dfs(int[] nums, int Index)
        {
            if (Index >= nums.Length)
            {
                return null;
            }


            TreeNode root = new TreeNode(nums[Index]);
            root.Left = BuildTree_Dfs(nums, 2 * Index + 1);
            root.Right = BuildTree_Dfs(nums, 2 * Index + 2);

            return root;
        }

        private TreeNode BuildTree_Bfs(int[] nums)
        { 
            
            Queue<TreeNode> queue = new Queue<TreeNode>();
            TreeNode root = new TreeNode(nums[0]);
            queue.Enqueue(root); 
            int i = 1;
            while (i<nums.Length)
            { 
                TreeNode current = queue.Dequeue();
                
                if ( i < nums.Length)
                {
                    current.Left = new TreeNode(nums[i++]);
                    queue.Enqueue(current.Left);
                }

                if (i < nums.Length)
                {
                    current.Right = new TreeNode(nums[i++]);
                    queue.Enqueue(current.Right);
                }

            }

            return root;
        }

        private void PrintTree(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            PrintTree(root.Left);
            Console.Write(root.Val + " ");
            PrintTree(root.Right);
        }


    }
}
