using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class FIndLeaves
    {
        public List<List<int>> find(TreeNode treeNode)
        { 
            List<List<int>> AllleafNodes = new List<List<int>>();

            //while (treeNode != null)
            //{
            //    List<int> leaves = new List<int>();
            //    dfs(treeNode, leaves);
            //    AllleafNodes.Add(leaves);
            //}
            int height = GetHeight(treeNode);
            return AllleafNodes; 
        }

        private int GetHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftHeight = GetHeight(node.Left);
            int rightHeight = GetHeight(node.Right);
            return 1 + Math.Max(leftHeight, rightHeight);
        }
        private void dfs(TreeNode treeNode, List<int> leaves)
        {
            if (treeNode == null)
            {
                return;
            }
            if (treeNode.Left == null && treeNode.Right == null)
            { 
                leaves.Add(treeNode.Val);
                treeNode = null;
                return;
            }

            List<List<int>> AllleafNodes = new List<List<int>>();
            dfs(treeNode.Left,leaves);
            dfs(treeNode.Right,leaves);
            return;

        }

        public TreeNode BuildTree()
        {
            TreeNode a = new TreeNode(1);
            TreeNode b = new TreeNode(2);
            TreeNode c = new TreeNode(3);
            TreeNode d = new TreeNode(4);
            a.Left = b;
            a.Right = c;
            b.Left = d;

            //TreeNode a = new TreeNode(1);
            //TreeNode b = new TreeNode(2);
            //TreeNode c = new TreeNode(3);
            //TreeNode d = new TreeNode(4);
            //TreeNode e = new TreeNode(5);
            //TreeNode f = new TreeNode(6);
            //a.Left = b;
            //a.Right = c;
            //c.Left = d;
            //c.Right = e;
            //e.Left = f;

            //TreeNode a = new TreeNode(1);
            //TreeNode b = new TreeNode(2);
            //TreeNode c = new TreeNode(3);
            //TreeNode d = new TreeNode(4);
            //a.Left = b;
            //b.Left = c;
            //c.Left = d;


            return a;

        }
    }
}
