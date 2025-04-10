using System;

namespace Meta.Graph.PracticeSimpleTraversal;

public class ConnectedComponentMatrix
{
    public void find(int[][] matrix)
    {
        if(matrix==null || matrix.Length==0)
        {
            return;
        }

       HashSet<int> Visited = new HashSet<int>();
       int count = 0;
       for(int i = 0;i<matrix.Length;i++)
       {
            if(!Visited.Contains(i))
            {
                traverse(matrix,Visited,i);
                count++;
            }
       }
    }

                
    private void traverse(int[][] matrix,HashSet<int> Visited,int i)
    {
        for(int j = 0;j<matrix.Length;j++)
        {
            if(matrix[i][j]==1 && !Visited.Contains(j))
            {
                Visited.Add(j);
                traverse(matrix,Visited,j);
            }
        }
    }

}


