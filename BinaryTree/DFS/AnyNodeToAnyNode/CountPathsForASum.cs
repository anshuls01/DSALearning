namespace BinaryTree.DFS;

public class CountPathsForASum
{
    public void Count(TreeNode root, int target)
    {
        if (root == null)
        {
            Console.WriteLine(0);
        }

        int result = find(root, target, new List<int>());
        int result2 = CountPathsPrefixSum(root, target, new Dictionary<int, int>(), 0);
        Console.WriteLine(result);
        Console.WriteLine(result2);
    }

    private int find(TreeNode root, int target, List<int> currentPath)
    {
        if (root == null)
        {
            return 0;
        }

        int PathFound = 0;
        int currentSum = 0;
        currentPath.Add(root.Val);
        int size = currentPath.Count;
        for (int i = size - 1; i >= 0; i--)
        {
            currentSum += currentPath[i];
            if (currentSum == target)
            {
                PathFound++;
                break;
            }
        }


        int leftCount = find(root.Left, target, currentPath);
        int rightCount = find(root.Right, target, currentPath);

        currentPath.RemoveAt(currentPath.Count - 1);

        return PathFound + leftCount + rightCount;
    }


    public int CountPathsPrefixSum(TreeNode node, int targetSum, Dictionary<int, int> map, int currentPathSum)
    {
        if (node == null)
            return 0;

        // The number of paths that have the required sum.
        int pathCount = 0;

        // 'currentPathSum' is the prefix sum, i.e., sum of all node values from the root to
        // the current node.
        currentPathSum += node.Val;

        // This is the base case. If the current sum is equal to the target sum, we have
        // found a path from root to the current node having the required sum. Hence, we 
        // increment the path count by 1.
        if (targetSum == currentPathSum)
            pathCount++;

        // 'currentPathSum' is the path sum from root to the current node. If within
        // this path, there is a valid solution, then there must be an 'oldPathSum' such that:
        // => currentPathSum - oldPathSum = targetSum
        // => currentPathSum - targetSum = oldPathSum
        // Hence, we can search such an 'oldPathSum' in the map from the key
        // 'currentPathSum - targetSum'.
        map.TryGetValue(currentPathSum - targetSum, out int count);
        pathCount += count;

        // This is the key step in the algorithm. We are storing the number of times the
        // prefix sum `currentPathSum` has occurred so far.
        if (map.ContainsKey(currentPathSum))
        {
            map[currentPathSum]++;
        }
        else
        {
            map[currentPathSum] = 1;
        }

        // Counting the number of paths from the left and right subtrees.
        pathCount += CountPathsPrefixSum(node.Left, targetSum, map, currentPathSum);
        pathCount += CountPathsPrefixSum(node.Right, targetSum, map, currentPathSum);

        // Removing the current path sum from the map for backtracking.
        // 'currentPathSum' is the prefix sum up to the current node. When we go back
        // (i.e., backtrack), then the current node is no more a part of the path, hence, w
        // e should remove its prefix sum from the map.
        map[currentPathSum]--;

        return pathCount;
    }

    public TreeNode BuildTree()
    {
        TreeNode root = new TreeNode(12);
        root.Left = new TreeNode(7);
        root.Right = new TreeNode(1);
        root.Left.Left = new TreeNode(4);
        root.Right.Left = new TreeNode(10);
        root.Right.Right = new TreeNode(5);
        return root;
    }
}