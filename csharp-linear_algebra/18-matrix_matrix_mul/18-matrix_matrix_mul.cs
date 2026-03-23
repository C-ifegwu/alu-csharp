using System;

/// <summary>
/// Class containing matrix math methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">First matrix (m x n).</param>
    /// <param name="matrix2">Second matrix (n x p).</param>
    /// <returns>The resulting matrix (m x p), or a matrix containing -1 if multiplication is not possible.</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null)
            return new double[,] { { -1 } };

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Inner dimensions must match
        if (cols1 != rows2)
            return new double[,] { { -1 } };

        double[,] result = new double[rows1, cols2];
        for (int i = 0; i < rows1; i++)
            for (int j = 0; j < cols2; j++)
            {
                double sum = 0;
                for (int k = 0; k < cols1; k++)
                    sum += matrix1[i, k] * matrix2[k, j];
                result[i, j] = Math.Round(sum, 2);
            }

        return result;
    }
}
