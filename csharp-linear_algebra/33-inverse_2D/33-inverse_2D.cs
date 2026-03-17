using System;

/// <summary>
/// Class containing matrix math utility methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2x2 matrix and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The 2x2 matrix to invert.</param>
    /// <returns>The inverted matrix, or [-1] if not 2x2 or non-invertible.</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix == null)
            return new double[,] { { -1 } };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2)
            return new double[,] { { -1 } };

        double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (det == 0)
            return new double[,] { { -1 } };

        double[,] result = new double[2, 2];
        result[0, 0] = Math.Round(matrix[1, 1] / det, 2);
        result[0, 1] = Math.Round(-matrix[0, 1] / det, 2);
        result[1, 0] = Math.Round(-matrix[1, 0] / det, 2);
        result[1, 1] = Math.Round(matrix[0, 0] / det, 2);

        return result;
    }
}
