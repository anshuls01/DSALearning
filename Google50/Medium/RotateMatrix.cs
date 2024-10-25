using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class RotateMatrix
    {
        public int[][] rotate(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            { 
                return null;
            }
            //this is not effective method
            //for (int m = 0; m < Math.Ceiling(matrix.Length/2.0); m++)
            //{
            //    for(int n = 0;n < Math.Ceiling(matrix[m].Length/2.0);n++)
            //    { 
            //        int temp = matrix[m][n];
            //        matrix[m][n] = matrix[matrix[m].Length - m - 1][n];
            //        matrix[matrix[m].Length - m - 1][n] = matrix[matrix.Length-m-1][matrix[m].Length - n - 1];
            //        matrix[matrix.Length - m - 1][matrix[m].Length - n - 1] = matrix[m][matrix[m].Length - n - 1];
            //        matrix[m][matrix[m].Length - n - 1] = temp;
            //    }
            //}

            // transpose and reverse
            //transpose
            for (int m = 0; m < matrix.Length; m++)
            {
                for (int n = m; n < matrix[m].Length; n++)
                { 
                    int temp = matrix[m][n];
                    matrix[m][n] = matrix[n][m];
                    matrix[n][m] = temp;
                }
            }

            for (int m = 0; m < matrix.Length; m++)
            {
                Array.Reverse(matrix[m]);
            }
                return matrix;
        }
    }
}
