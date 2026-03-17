using System;

/// <summary>
/// Class containing matrix math utility methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The matrix (2x2 or 3x3).</param>
    /// <param name="scalar">The scalar value to multiply by.</param>
    /// <returns>The resulting matrix, or a matrix containing -1 if invalid input.</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix == null)
            return new double[,] { { -1 } };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        bool isValid = (rows == 2 && cols == 2) || (rows == 3 && cols == 3);
        if (!isValid)
            return new double[,] { { -1 } };

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = matrix[i, j] * scalar;

        return result;
    }
}
