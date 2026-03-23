using System;

/// <summary>
/// Class containing matrix math methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">A 2x2 or 3x3 matrix.</param>
    /// <param name="scalar">A scalar value to multiply with.</param>
    /// <returns>The resulting matrix, or a matrix containing -1 if the matrix is invalid.</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix == null)
            return new double[,] { { -1 } };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        bool valid = (rows == 2 && cols == 2) || (rows == 3 && cols == 3);
        if (!valid)
            return new double[,] { { -1 } };

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = Math.Round(matrix[i, j] * scalar, 2);

        return result;
    }
}
