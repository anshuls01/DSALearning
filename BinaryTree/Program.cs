// See https://aka.ms/new-console-template for more information

using BinaryTree;
using BinaryTree.BFS;
using BinaryTree.BFS.Revision;
using BinaryTree.DFS;
using BinaryTree.DFS.AnyNodeToAnyNode;

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
//MaxRootToLeafPathSum maxRootToLeafPathSum = new MaxRootToLeafPathSum();
//Console.WriteLine(maxRootToLeafPathSum.MaxPathSum_DFS_Recursive(maxRootToLeafPathSum.BuildTreee()));

//CreateTreeFromArray createTreeFromArray = new CreateTreeFromArray();
//createTreeFromArray.BuildTree(new int[] { 1,2,3,4,5,6,7});

Console.WriteLine("--------------- BFS ------------------");
// TreeLevelOrderTraversal treeLevelOrderTraversal = new TreeLevelOrderTraversal();
// treeLevelOrderTraversal.print(treeLevelOrderTraversal.BuildTree());

// Console.WriteLine("-----------");


//ReverseLevelOrderTraversal reverseLevelOrderTraversal = new ReverseLevelOrderTraversal();
//reverseLevelOrderTraversal.print(reverseLevelOrderTraversal.BuildTree());
//r_ReverseLevelOrderTraversal r_ReverseLevelOrderTraversal = new r_ReverseLevelOrderTraversal();
//r_ReverseLevelOrderTraversal.print(reverseLevelOrderTraversal.BuildTree());

// Console.WriteLine("-----------");

//ZigzagTraversal zigzagTraversal = new ZigzagTraversal();
//zigzagTraversal.print(zigzagTraversal.BuildTree());

//r_LevelAvgInBinaryTree levelAvgInBinaryTree = new r_LevelAvgInBinaryTree();
//levelAvgInBinaryTree.print(levelAvgInBinaryTree.BuildTree());

// MaxNodeValueAtEachLevel maxNodeValueAtEachLevel = new MaxNodeValueAtEachLevel();
// maxNodeValueAtEachLevel.print(maxNodeValueAtEachLevel.BuildTree());

Console.WriteLine("-------------- DFS ------------------");
//AllPathForASum allPathForASum = new AllPathForASum();
//allPathForASum.Print(allPathForASum.BuildTree(), 23);
//allPathForASum.Print_v1(allPathForASum.BuildTree(), 23);

//AllPathForASum1 allPathForASum1 = new AllPathForASum1();
//allPathForASum1.Print(allPathForASum.BuildTree(), 23);
//allPathForASum1.Print_BackTracking(allPathForASum.BuildTree(), 23);

// AllPathSumForASum_BackTracking allPathSumForASumBackTracking = new AllPathSumForASum_BackTracking();
// allPathSumForASumBackTracking.Print(allPathSumForASumBackTracking.BuildTree(),23);

//
// AllRootToLeafPaths allRootToLeafPaths = new AllRootToLeafPaths();
// allRootToLeafPaths.Print(allRootToLeafPaths.BuildTree());

// MaxSumPathRootToLeaf maxSumPathRootToLeaf = new MaxSumPathRootToLeaf();
// maxSumPathRootToLeaf.Print(maxSumPathRootToLeaf.BuildTree());
//
//SumOfPathNumbers sumOfPathNumbers = new SumOfPathNumbers();
//sumOfPathNumbers.Print(sumOfPathNumbers.BuildTree());
//sumOfPathNumbers.Print_v1(sumOfPathNumbers.BuildTree());

//CountPathsForASum countPathsForASum = new CountPathsForASum();
//CountPathsForASum1 countPathsForASum1 = new CountPathsForASum1();
//countPathsForASum.Count(countPathsForASum.BuildTree(), 11);
//Console.WriteLine(countPathsForASum1.find(countPathsForASum.BuildTree(), new List<int>(),11));
//Console.WriteLine(countPathsForASum1.find1(countPathsForASum.BuildTree(), new Dictionary<int, int>(), 11));
//countPathsForASum1.find(countPathsForASum.BuildTree(), 11);
//
// TreeDiameter treeDiameter = new TreeDiameter();
// treeDiameter.findDiameter(treeDiameter.BuildTree());

PathWithMaximumSum pathWithMaximumSum = new PathWithMaximumSum();
pathWithMaximumSum.maxPathSumNodetoNode(pathWithMaximumSum.BuildTree());
PathWithMaximumSum1 pathWithMaximumSum1 = new PathWithMaximumSum1();
pathWithMaximumSum1.findPathWithMaxSum(pathWithMaximumSum.BuildTree());
