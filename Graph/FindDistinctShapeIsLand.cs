using System.Text;

namespace Graph;

public class FindDistinctShapeIsLand
{
    public void find(int[][] matrix)
    {
        int distinctIsLand = 0;
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
        {
            Console.WriteLine(distinctIsLand);
        }

        HashSet<string> visited = new HashSet<string>();
        HashSet<string> Paths = new HashSet<string>();
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                if (matrix[row][col] == 1 && !visited.Contains($"{row}_{col}"))
                {
                    StringBuilder sb = new StringBuilder();
                    bool result = TraverseMatrix(matrix, visited, row, col, "O", sb);
                    if (result)
                    {
                        Paths.Add(sb.ToString());
                    }
                }
            }
        }

        distinctIsLand = Paths.Count;
        foreach (string path in Paths)
            Console.WriteLine(path);

        Console.WriteLine(distinctIsLand);
    }

    private bool TraverseMatrix(int[][] matrix, HashSet<string> visited, int row, int col, string direction,
        StringBuilder sb)
    {
        bool rowInBound = row >= 0 && row < matrix.Length;
        bool colInBound = col >= 0 && col < matrix[0].Length;

        if (!rowInBound || !colInBound)
        {
            return false;
        }

        if (matrix[row][col] == 0)
        {
            return false;
        }

        string key = $"{row}_{col}";
        if (visited.Contains(key))
        {
            return false;
        }

        visited.Add(key);
        sb.Append(direction);


        TraverseMatrix(matrix, visited, row + 1, col, "D", sb);
        TraverseMatrix(matrix, visited, row, col + 1, "R", sb);
        TraverseMatrix(matrix, visited, row - 1, col, "U", sb);
        TraverseMatrix(matrix, visited, row, col - 1, "L", sb);
        return true;
    }
}