using System;

/// <summary>
/// Class containing matrix math utility methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Transposes a matrix and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The matrix to transpose (any dimension).</param>
    /// <returns>The transposed matrix, or an empty matrix if input is empty.</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix == null)
            return new double[0, 0];

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows == 0 || cols == 0)
            return new double[0, 0];

        double[,] result = new double[cols, rows];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[j, i] = matrix[i, j];

        return result;
    }
}
