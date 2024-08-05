namespace Graph;

public class FloodFill
{
    public int[][] floodFill(int[][] matrix, int x, int y, int newColor) {
        // TODO: Write your code here
        if(matrix==null || matrix.Length==0 || matrix[0].Length==0)
        {
            return matrix;
        }
        bool rowInBound = x>=0 && x<matrix.Length;
        bool colInBound = y>=0 && y<matrix[0].Length;
        if(!rowInBound || !colInBound)
        {
            return matrix;
        }

        int currentColor = matrix[x][y];
        HashSet<string> visited = new HashSet<string>();
        traverseMatrix(matrix,visited,x,y,newColor,currentColor);
        return matrix;
    }
    private void traverseMatrix(int[][] matrix, HashSet<string> visited, int row, int col, int newColor, int currentColor)
    {
        bool rowInBound = row>=0 && row<matrix.Length;
        bool colInBound = col>=0 && col<matrix[0].Length;
        if(!rowInBound || !colInBound)
        {
            return;
        }

        string key= $"{row}_{col}";
        if(visited.Contains(key))
        {
            return;
        }
        visited.Add(key);
        if(matrix[row][col]!=currentColor)
        {
            return;
        }
        matrix[row][col]= newColor;
        traverseMatrix(matrix,visited,row+1,col,newColor,currentColor);
        traverseMatrix(matrix,visited,row,col+1,newColor,currentColor);
        traverseMatrix(matrix,visited,row-1,col,newColor,currentColor);
        traverseMatrix(matrix,visited,row,col-1,newColor,currentColor);
        return;
    }
}