using System;

/// <summary>
/// Class containing matrix math methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">First 2x2 or 3x3 matrix.</param>
    /// <param name="matrix2">Second 2x2 or 3x3 matrix.</param>
    /// <returns>The resulting matrix, or a matrix containing -1 if inputs are invalid.</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null)
            return new double[,] { { -1 } };

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Check both are 2D (2x2) or 3D (3x3)
        bool valid1 = (rows1 == 2 && cols1 == 2) || (rows1 == 3 && cols1 == 3);
        bool valid2 = (rows2 == 2 && cols2 == 2) || (rows2 == 3 && cols2 == 3);

        if (!valid1 || !valid2 || rows1 != rows2 || cols1 != cols2)
            return new double[,] { { -1 } };

        double[,] result = new double[rows1, cols1];
        for (int i = 0; i < rows1; i++)
            for (int j = 0; j < cols1; j++)
                result[i, j] = matrix1[i, j] + matrix2[i, j];

        return result;
    }
}
