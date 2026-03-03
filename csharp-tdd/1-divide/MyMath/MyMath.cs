using System;

namespace MyMath
{
    /// <summary>
    /// Matrix class
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of a matrix.
        /// </summary>
        /// <param name="matrix">The matrix</param>
        /// <param name="num">The number to divide by</param>
        /// <returns>A new matrix containing divided elements</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            try
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                int[,] newMatrix = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        newMatrix[i, j] = matrix[i, j] / num;
                    }
                }

                return newMatrix;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
