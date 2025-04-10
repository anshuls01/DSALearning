namespace Meta.Trees;

public class ValidateBST
{
    public TreeNode PrepreTree()
    {
        TreeNode node = new TreeNode(5);
        node.Left = new TreeNode(1);
        node.Right = new TreeNode(4);
        node.Right.Left = new TreeNode(3);
        node.Right.Right = new TreeNode(6);

        return node;
    }

    
    public bool IsValidBST(TreeNode root) {
        //using inorder traversal
        int? prev = null;

        return inOrder( root,prev); 
    }
    private bool inOrder(TreeNode root,int? prev)
    {

        if(root==null)
        {
            return true;
        }
        if(!inOrder(root.Left,prev))
        {
            return false;
        }
       

        if(prev.HasValue && prev.Value>=root.Val)
        {
            return false;
        }
        prev = root.Val;
        return inOrder(root.Right,prev);
    }
}