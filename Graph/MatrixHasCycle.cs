using Microsoft.VisualBasic;

namespace Graph;

public class MatrixHasCycle
{
    public void hasCycle(char[][] matrix) 
    {
        // TODO: Write your code here
        if (matrix==null || matrix.Length==0 || matrix[0].Length==0)
        {
            Console.WriteLine(false);
        }

        HashSet<string> visited = new HashSet<string>();
      
        for(int row = 0;row<matrix.Length;row++)
        {
            for(int col = 0;col<matrix[0].Length;col++)
            {
                if(!visited.Contains($"{row}_{col}"))
                {
                    bool result = TraverseMatrix(matrix,visited, row, col, matrix[row][col]);
                    //Console.WriteLine(string.Join(",", currentpath));
                    if(result)
                    {
                        Console.WriteLine(true);
                        break;
                    }
                }
            }
        }

        Console.WriteLine(false);
    }

    private bool TraverseMatrix(char[][] matrix,HashSet<string> visited,int row, int col, char currentChar)
    {
        bool rowInBound = row>=0 && row<matrix.Length;
        bool colInBound = col>=0 && col<matrix[0].Length;
        if(!rowInBound || !colInBound)
        {
            return false;
        }

        if(matrix[row][col]!=currentChar)
        {
            return false;
        }
        string key = $"{row}_{col}";
        if(visited.Count>=4 &&  visited.Contains(key))
        {
            return true;
        }

        if (visited.Contains(key))
        {
            return false;
        }

        visited.Add(key);
        //currentpath.Add(key);

        TraverseMatrix(matrix,visited, row+1, col, currentChar);
        TraverseMatrix(matrix,visited,row, col+1, currentChar);
        TraverseMatrix(matrix,visited,row-1, col, currentChar);
        TraverseMatrix(matrix,visited,row, col-1, currentChar);
        return false;
    }
    
    private int[] getPrefixSumArray(int[] nums)
    {
        int[] prefix = new int[nums.Length];
        prefix[0] = nums[0];
        for(int n = 1;n<nums.Length;n++)
        {
            prefix[n] = prefix[n-1] + nums[n];
        }

        return prefix;
    }
}