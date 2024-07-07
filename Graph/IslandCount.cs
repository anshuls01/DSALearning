using System.Data;

namespace Graph;

public class IslandCount
{
    public int Solve(char[,] grid)
    {
        if (grid == null || grid.GetLength(0) == 0 || grid.GetLength(1) == 0)
        {
            return 0;
        }

        int rowLength = grid.GetLength(0);
        int colLength = grid.GetLength(1);
        int count = 0;
        HashSet<string> visited = new HashSet<string>();
        for (int r = 0; r < rowLength; r++)
        {
            for (int c = 0; c < colLength; c++)
            {
                if (!visited.Contains($"{r}_{c}"))
                {
                    bool result = traverseGrid(grid, r, c, rowLength, colLength, visited);
                    if (result)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }

    private bool traverseGrid(char[,] grid, int r, int c, int rows, int cols, HashSet<string> visited)
    {
        string key = $"{r}_{c}";
        bool rowbound = r >= 0 && r < rows;
        bool colbound = c >= 0 && c < cols;

        if (!rowbound || !colbound)
        {
            return false;
        }

        if (visited.Contains(key))
        {
            return false;
        }

        visited.Add(key);
        if (grid[r, c] == 'W')
        {
            return false;
        }
        traverseGrid(grid, r+1, c, rows, cols, visited);
        traverseGrid(grid, r, c+1, rows, cols, visited);
        traverseGrid(grid, r-1, c, rows, cols, visited);
        traverseGrid(grid, r, c-1, rows, cols, visited);
        
        return true;
    }
}