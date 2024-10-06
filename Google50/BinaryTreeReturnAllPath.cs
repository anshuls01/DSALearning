using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50
{
    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int x) { Val = x; }
    }
    public class BinaryTreeReturnAllPath
    {
        public List<string> binaryTreePaths(TreeNode root)
        {
            List<string> paths = new List<string>();
            // ToDo: Write Your Code Here.
            if (root == null)
            {
                return paths;
            }
            findPaths(paths, "", root);
            return paths;
        }

        private void findPaths(List<string> paths, string path, TreeNode root)
        {
            path = path + root.Val;
            if (root.Left == null && root.Right == null)
            {
                paths.Add(path);
                return;
            }
            path = path + "->";
            findPaths(paths, path, root.Left);
            findPaths(paths, path, root.Right);
        }
        private void findPaths1(List<string> paths, string path, TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            path += root.Val;

            if (root.Left == null && root.Right == null)
            {
                paths.Add(path);
                return;
            }

            path += "->";
            findPaths(paths, path, root.Left);
            findPaths(paths, path, root.Right);



        }

        public TreeNode buildTree()
        {
            TreeNode a = new TreeNode(1);
            TreeNode b = new TreeNode(2);
            TreeNode c = new TreeNode(3);
            TreeNode d = new TreeNode(4);
            TreeNode e = new TreeNode(5);

            a.Left = b;
            a.Right = c;
            c.Left = d;
            c.Right = e;
            return a;

        }
    }
}
