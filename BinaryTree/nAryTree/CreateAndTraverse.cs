namespace BinaryTree.nAryTree
{
    public class CreateAndTraverse
    {
        public class TreeNode
        {
            public int value;
            public List<TreeNode> Children;
            public TreeNode(int value)
            {
                this.value = value;
                Children = new List<TreeNode>();
            }
        }

        public void DFS(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.value);
            foreach (TreeNode childNode in node.Children)
            { 
                DFS(childNode);
            }
        }
    }
}
