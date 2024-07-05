// See https://aka.ms/new-console-template for more information

using BinaryTree;

Console.WriteLine("Binary Tree");

//T: O(n)  S:" O(n)
// TreeInclude treeInclude = new TreeInclude();
// Console.WriteLine(treeInclude.Exist_DFS_Recursive(treeInclude.BuildTreee(),'b'));
// Console.WriteLine(treeInclude.Exist_DFS_Stack(treeInclude.BuildTreee(),'c'));
// Console.WriteLine(treeInclude.Exist_BFS_Queue(treeInclude.BuildTreee(),'c'));


// // T: O(n) S: O(n)
// TreeSum treeSum = new TreeSum();
// Console.WriteLine(treeSum.Sum_DFS_Recursive(treeSum.BuildTreee()));
// Console.WriteLine(treeSum.Sum_BFS_Queue(treeSum.BuildTreee()));

// // T: O(n) S:O(n)
// TreeMInValue treeMInValue = new TreeMInValue();
// Console.WriteLine(treeMInValue.MinValue_DFS_Recursive(treeMInValue.BuildTreee()));
// Console.WriteLine(treeMInValue.MinValue_BFS_Queue(treeMInValue.BuildTreee()));


// T: O(n) S: O(n)
MaxRootToLeafPathSum maxRootToLeafPathSum = new MaxRootToLeafPathSum();
Console.WriteLine(maxRootToLeafPathSum.MaxPathSum_DFS_Recursive(maxRootToLeafPathSum.BuildTreee()));