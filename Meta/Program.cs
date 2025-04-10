using System;
using Meta.Recursion;
using Meta.Strings;
using Meta.Trees;
using Meta.Trees.PracticeDFS;

// ValidateBST vbst = new ValidateBST();
// Console.WriteLine(vbst.IsValidBST(vbst.PrepreTree()));

// AllPathSum allPathSum = new AllPathSum();
// allPathSum.Solve(allPathSum.PrepreTree(),12);

// NumberSum numberSum = new NumberSum();
// numberSum.solve(numberSum.PrepreTree());

// CountPathsforaSum countPathsforaSum = new CountPathsforaSum();
// Console.WriteLine(countPathsforaSum.solve(countPathsforaSum.PrepreTree(),12,new List<int>()));

// MergeSortedArray merge = new MergeSortedArray();
// merge.solve_extraSpace([1,2,3,0,0,0],3,[2,5,6],3);
// merge.solve_withoutExtraSpace([1,2,3,0,0,0],3,[2,5,6],3);

// RemoveInnvalidParanthesis removeInnvalid = new RemoveInnvalidParanthesis();
// Console.WriteLine(string.Join(",", removeInnvalid.solve("()())()")));

// threeSum threeSum = new threeSum();
// threeSum.findTriplet([-1,0,1,2,-1,-4]);

// ThreeSumWithHashSet threeSumWithHashSet = new ThreeSumWithHashSet();
// threeSumWithHashSet.solve([-1,0,1,2,-1,-4]);
ThreeSumNoSortHashSet threeSumNoSortHashSet = new ThreeSumNoSortHashSet();
threeSumNoSortHashSet.solve([-1,0,1,2,-1,-4]);