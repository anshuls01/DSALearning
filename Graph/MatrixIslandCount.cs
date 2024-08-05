namespace Graph;

public class MatrixIslandCount
{
    public void Solution(int[][] matrix)
    {
        if (matrix == null || matrix.Length==0)
        {
            return;
        }

        int count = 0;
        HashSet<string> visited = new HashSet<string>();
        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = 0; c < matrix[r].Length; c++)
            {
                if (!visited.Contains($"{r}_{c}"))
                {
                    bool result = TraverseMatrix(matrix, visited, r,c);
                    if (result)
                    {
                        count++;
                    }
                }
            }
        }

        Console.WriteLine(count);
        
    }

    private bool TraverseMatrix(int[][] matrix, HashSet<string> visited,int row, int col)
    {
        bool rowInBound = row >= 0 && row < matrix.Length;
        bool colInBound = col >= 0 && col < matrix[0].Length;

        if (!rowInBound || !colInBound)
        {
            return false;
        }

        string key = $"{row}_{col}";
        if (visited.Contains(key))
        {
            return false;
        }
        visited.Add(key);
        if (matrix[row][col] == 0)
        {
            return false;
        }
        
        TraverseMatrix(matrix, visited, row+1,col);
        TraverseMatrix(matrix, visited, row,col+1);
        TraverseMatrix(matrix, visited, row-1,col);
        TraverseMatrix(matrix, visited, row,col-1);

        return true;
    }
}