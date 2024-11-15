using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class MatrixNearestZero
    {
        public int[][] find(int[][] matrix)
        {
            if (matrix.Length == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return matrix;
            }

            Queue<NodePosition> queue = getQueue(matrix);
            List<Node> moves = getMoves();
            HashSet<string> set = new HashSet<string>();
            while (queue.Count > 0)
            { 
                NodePosition currentPosition = queue.Dequeue();
                Node traveledNode = currentPosition.traveledNode;
                if (matrix[traveledNode.row][traveledNode.col] != 0)
                {
                    matrix[traveledNode.row][traveledNode.col] = currentPosition.distance;
                  
                }
                foreach (Node move in moves) {
                    if (validPosition(matrix,traveledNode.row + move.row, traveledNode.col + move.col, set))
                    {
                        queue.Enqueue(new NodePosition(traveledNode.row + move.row, traveledNode.col + move.col, currentPosition.distance + 1));
                        set.Add($"{traveledNode.row + move.row}_{traveledNode.col + move.col}");
                    }
                } 
            }
            return matrix;
        }

        private bool validPosition(int[][] matrix, int row, int col, HashSet<string> set)
        {
            bool isRowInBound = row>=0 && row<matrix.Length;
            bool isColInBound = col>=0 && col < matrix[0].Length;
            if (!isRowInBound || !isColInBound)
            {
                return false;
            }
            if (set.Contains($"{row}_{col}"))
            {
                return false;
            }
            if (matrix[row][col] == 0)
            {
                return false;
            }
            return true;
        }

        private List<Node> getMoves()
        {
            return new List<Node>{new Node( 1, 0 ), new Node(0, 1), new Node(-1, 0), new Node(0, -1 )};
        }

        private Queue<NodePosition> getQueue(int[][] matrix)
        {
            Queue<NodePosition> queue = new Queue<NodePosition>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        queue.Enqueue(new NodePosition(i, j, 0));
                    }
                }
            }
            return queue;
        }

        internal class NodePosition
        {
            public Node traveledNode;
            public int distance;
            public NodePosition(int r, int c, int d)
            {
                traveledNode = new Node(r, c);
                distance = d;
            }

        }
        internal class Node
        {
            public int row;
            public int col;

            public Node(int r, int c)
            {
                row = r;
                col = c;
            }
        }
    }
}