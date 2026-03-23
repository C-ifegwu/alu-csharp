using System;

/// <summary>
/// Class containing matrix math methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates the determinant of a 2x2 or 3x3 matrix.
    /// </summary>
    /// <param name="matrix">A 2x2 or 3x3 matrix.</param>
    /// <returns>The determinant rounded to the nearest hundredth, or -1 if the matrix is invalid.</returns>
    public static double Determinant(double[,] matrix)
    {
        if (matrix == null)
            return -1;

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows == 2 && cols == 2)
        {
            double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            return Math.Round(det, 2);
        }
        else if (rows == 3 && cols == 3)
        {
            double det =
                matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
            return Math.Round(det, 2);
        }

        return -1;
    }
}
