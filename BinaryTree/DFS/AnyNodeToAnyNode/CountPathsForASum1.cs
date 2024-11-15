using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.DFS.AnyNodeToAnyNode
{
    internal class CountPathsForASum1
    {

        public int find(TreeNode root, List<int> path, int target)
        {
            if (root == null)
            {
                return 0;
            }

            path.Add(root.Val);
            int sum = 0;
            int pathCount = 0;
            for (int i = path.Count - 1; i >= 0; i--)
            {
                sum += path[i];
                if (sum == target)
                {
                    pathCount++;
                }
            }
            pathCount += find(root.Left, path, target);
            pathCount += find(root.Right, path, target);

            path.RemoveAt(path.Count - 1);
            return pathCount;
        }

        public int find1(TreeNode root, Dictionary<int,int> map, int target, int pathSum=0)
        {
            if (root == null)
            {
                return 0;
            }
            int pathCount = 0;
            pathSum += root.Val;
            
            if (pathSum == target)
            {
                pathCount++;
            }
            
            if (map.ContainsKey(pathSum - target))
            { 
                pathCount+=map[pathSum - target];
            }

            if (map.ContainsKey(pathSum))
            {
                map[pathSum]++;
            }
            else
            {
                map[pathSum]=1;
            }

            pathCount += find1(root.Left, map, target, pathSum);
            pathCount += find1(root.Right, map, target,pathSum);

            map[pathSum]--;
            return pathCount;
        }
    }
}
