namespace BackTracking;

public class WordSearch
{
    public bool exist(char[][] board, string word) {
        // TODO: Write your code here
        if(board==null || board.Length==0 || board[0].Length==0)
        {
            return false;
        }

        HashSet<string> visited = new HashSet<string>();
        for(int row = 0;row<board.Length;row++)
        {
            for(int col = 0;col<board[0].Length;col++)
            {
                visited = new HashSet<string>();
                bool result = find(board,row,col,word,0, visited);
                if(result)
                {
                    return result;
                }
            }
        }
        return false;
    }
    private bool find(char[][] board,int row, int col,string word,int index, HashSet<string> visited)
    {
        bool rowInBound = row>=0 && row<board.Length;
        bool colInBound = col>=0 && col<board[0].Length;
        if(!rowInBound || !colInBound)
        {
            return false;
        }

        string key = $"{row}_{col}";
        if(visited.Contains(key))
        {
            return false;
        }
        visited.Add(key);
        if(index==word.Length-1 && word[index]==board[row][col])
        {
            return true;
        }
        find(board,row+1,col,word,index+1, visited);
        find(board,row,col+1,word,index+1, visited);
        find(board,row-1,col,word,index+1, visited);
        find(board,row,col-1,word,index+1, visited);
        return false;

    }
}