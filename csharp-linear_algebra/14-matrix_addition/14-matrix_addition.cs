using System;

/// <summary>
/// Class containing matrix math utility methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">The first matrix (2x2 or 3x3).</param>
    /// <param name="matrix2">The second matrix (2x2 or 3x3).</param>
    /// <returns>The resulting matrix, or a matrix containing -1 if invalid input.</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null)
            return new double[,] { { -1 } };

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        bool isValid1 = (rows1 == 2 && cols1 == 2) || (rows1 == 3 && cols1 == 3);
        bool isValid2 = (rows2 == 2 && cols2 == 2) || (rows2 == 3 && cols2 == 3);

        if (!isValid1 || !isValid2 || rows1 != rows2 || cols1 != cols2)
            return new double[,] { { -1 } };

        double[,] result = new double[rows1, cols1];
        for (int i = 0; i < rows1; i++)
            for (int j = 0; j < cols1; j++)
                result[i, j] = matrix1[i, j] + matrix2[i, j];

        return result;
    }
}
