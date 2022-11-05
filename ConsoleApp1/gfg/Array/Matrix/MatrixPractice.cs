using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1.gfg.Array.Matrix
{
    internal class MatrixPractice
    {
        internal void SimpleMatrixTraversal()
        {
            int[,] test = new int[,] { { 2, 3, 4 }, { 3, 4, 5 }, { 4, 5, 6 } };

            for (int i = 0; i < test.GetLength(0); i++)
            {
                for (int j = 0; j < test.GetLength(1); j++)
                {
                    Console.Write(test[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        internal void SnakePatternOfMatrix(int[,] arr)
        {
            int row = arr.GetLength(0);
            int column = arr.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }
                else
                {
                    for (int k = column - 1; k >= 0; k--)
                    {
                        Console.Write(arr[i, k] + " ");
                    }
                }
            }
        }

        internal void MatrixBoundaryTraversal(int[,] arr)
        {
            int row = arr.GetLength(0);
            int column = arr.GetLength(1);

            if (column > 0)
            {
                for (int i = 0; i < column; i++)
                {
                    Console.Write(arr[0, i]);
                }
            }
            if (row > 1)
            {
                for (int i = 1; i < row; i++)
                {
                    Console.Write(arr[i, column - 1]);
                }
                for (int i = column - 2; i >= 0; i--)
                {
                    Console.Write(arr[row - 1, i]);
                }
                if (column > 1)
                {
                    for (int i = row - 2; i > 0; i--)
                    {
                        Console.Write(arr[i, 0]);
                    }
                }

            }


        }

        internal void TransposeOfMatrix(int[,] arr)
        {
            PrintMatrix(arr);
            Console.WriteLine("+++++++++++++++++++++++++++");
            int row = arr.GetLength(0);
            int column = arr.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = i + 1; j < column; j++)
                {

                    int temp = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = temp;

                }
            }
            PrintMatrix(arr);
        }

        /// <summary>
        /// first get transpose of matrix 
        /// and then reverse the columns
        /// </summary>
        /// <param name="matrix"></param>
        internal void RotateMatrixBy90Degree(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            PrintMatrix(matrix);
            Console.WriteLine("+++++++++++++++++++++++++++");
            for (int i = 0; i < rows; i++)
            {
                for (int j = i + 1; j < cols; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            for (int i = 0; i < cols; i++)
            {
                int low = 0, end = rows - 1;
                while (low < end)
                {
                    int temp = matrix[low, i];
                    matrix[low, i] = matrix[end, i];
                    matrix[end, i] = temp;
                    low++;
                    end--;
                }
            }
            PrintMatrix(matrix);
        }

        internal void SpiralTraversalOfMatrix(int[,] matrix)
        {
            PrintMatrix(matrix);
            Console.WriteLine("+++++++++++++++++++++++++");
            int top = 0, right = matrix.GetLength(1) - 1, bottom = matrix.GetLength(0) - 1, left = 0;
            while (top <= bottom && left <= right)
            {
                ///top row
                for (int i = left; i <= right; i++)
                {
                    Console.Write(matrix[top, i] + " ");
                }
                top++;
                ///right column
                for (int i = top; i <= bottom; i++)
                {
                    Console.Write(matrix[i, right] + " ");
                }
                right--;
                ///bottom row
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        Console.Write(matrix[bottom, i] + " ");
                    }
                }
                bottom--;

                ///left column
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        Console.Write(matrix[i, left] + " ");
                    }
                }
                left++;

            }

        }

        internal void Search(int[,] matrix, int x)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int i = 0, j = col - 1;
            while (i < row && j >= 0)
            {
                int topRight = matrix[i, j];
                if (topRight == x)
                {
                    Console.WriteLine($"found at row {i} and column {j}");
                }
                else if (topRight > x)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("Not found");
        }

        //Function to add two matrices.
        public List<List<int>> SumMatrix(List<List<int>> A, List<List<int>> B)
        {
            List<List<int>> result = new List<List<int>>();
            if (A.Count == B.Count && A[0].Count == B.Count)
            {
                int rows = A.Count;

                for (int i = 0; i < rows; i++)
                {
                    List<int> row = new List<int>();
                    for (int j = 0; j < A[i].Count; j++)
                    {
                        row.Add(A[i][j] + B[i][j]);
                    }
                    result.Add(row);
                }
            }
            return result;
        }

        //Function to return sum of upper and lower triangles of a matrix.
        public List<int> sumTriangles(List<List<int>> matrix, int n)
        {
            int upper_sum = 0, lower_sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i <= j)
                    {
                        lower_sum += matrix[i][j];
                    }
                    if (i >= j)
                    {
                        upper_sum += matrix[i][j];
                    }
                }
            }
            return new List<int>() { upper_sum, lower_sum };
        }

        //Function to return list of integers visited in snake pattern in matrix.
        public List<int> SnakePattern(List<List<int>> matrix)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < matrix.Count; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix[i].Count; j++)
                    {
                        result.Add(matrix[i][j]);
                    }
                }
                else
                {
                    for (int j = matrix[i].Count - 1; j >= 0; j++)
                    {
                        result.Add(matrix[i][j]);
                    }
                }

            }
            return result;
        }

        //Function to find transpose of a matrix.
        public void transpose(List<List<int>> matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }

        //Function to rotate matrix anticlockwise by 90 degrees.
        public void rotateby90(List<List<int>> matrix, int n)
        {
            transpose(matrix, n);

            for (int i = 0; i < n; i++)
            {
                int start = 0, end = n - 1;
                while (start < end)
                {
                    int temp = matrix[i][start];
                    matrix[i][start] = matrix[i][end];
                    matrix[i][end] = temp;
                    start++;
                    end--;
                }
            }
        }

        //Function to return list of integers that form the boundary 
        //traversal of the matrix in a clockwise manner.
        public List<int> boundaryTraversal(List<List<int>> matrix, int n, int m)
        {
            int top = 0, right = m - 1, bottom = n - 1, left = 0;
            List<int> result = new List<int>();
            do
            {
                ///top row
                for (int i = left; i <= right; i++)
                {
                    result.Add(matrix[top][i]);
                }
                top++;
                ///right column
                for (int i = top; i <= bottom; i++)
                {
                    result.Add(matrix[i][right]);

                }
                right--;
                ///bottom row
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(matrix[bottom][i]);
                    }
                }
                bottom--;

                ///left column
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        result.Add(matrix[i][left]);

                    }
                }
                left++;
            } while (false);
            return result;
        }

        //Function to reverse the columns of a matrix.
        public void reverseCol(List<List<int>> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                int start = 0, end = matrix[i].Count - 1;
                while (start < end)
                {
                    int temp = matrix[i][start];
                    matrix[i][start] = matrix[i][end];
                    matrix[i][end] = temp;
                    start++;
                    end--;
                }
            }
        }

        //Function to interchange the rows of a matrix.
        public void interchangeRows(List<List<int>> matrix)
        {
            for (int i = 0; i < matrix[0].Count; i++)
            {
                int start = 0, end = matrix.Count - 1;
                while (start < end)
                {
                    int temp = matrix[start][i];
                    matrix[start][i] = matrix[end][i];
                    matrix[end][i] = temp;
                    start++;
                    end--;
                }
            }
        }

        //Function to search a given number in row-column sorted matrix.
        public bool search(List<List<int>> matrix, int n, int m, int x)
        {
            int i = 0, j = m - 1;

            while (i < n && j >= 0)
            {
                if (matrix[i][j] == x)
                {
                    return true;
                }
                else if (matrix[i][j] > x)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return false;
        }

        //Function to multiply two matrices.
        public List<List<int>> sumMatrix(List<List<int>> A, List<List<int>> B)
        {
            List<List<int>> result = new List<List<int>>();

            if (A[0].Count != B.Count)
            {
                return new List<List<int>>();
            }

            for (int i = 0; i < A.Count; i++)
            {
                List<int> multi = new List<int>();
                for (int k = 0; k < B[0].Count; k++)
                {
                    int sum = 0;
                    for (int j = 0; j < B.Count; j++)
                    {
                        sum += A[i][j] * B[j][k];
                    }
                    multi.Add(sum);
                }
                result.Add(multi);
            }
            return result;
        }

        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i < rows - 1 && j < cols - 1 && matrix[i][j] != matrix[i + 1][j + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void PrintMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
