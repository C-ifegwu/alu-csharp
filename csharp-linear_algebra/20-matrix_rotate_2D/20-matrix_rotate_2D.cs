using System;

/// <summary>
/// Class containing matrix math methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    /// Each element's value is rotated by the angle — not the positions of the elements.
    /// </summary>
    /// <param name="matrix">A square 2D matrix (2x2).</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>The rotated matrix, or a matrix containing -1 if the matrix is invalid.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null)
            return new double[,] { { -1 } };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2)
            return new double[,] { { -1 } };

        double cosA = Math.Round(Math.Cos(angle), 10);
        double sinA = Math.Round(Math.Sin(angle), 10);

        // Rotation matrix: [[cos, -sin], [sin, cos]]
        double[,] rotMatrix = new double[,]
        {
            { cosA, -sinA },
            { sinA,  cosA }
        };

        double[,] result = new double[2, 2];
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
            {
                double sum = 0;
                for (int k = 0; k < 2; k++)
                    sum += rotMatrix[i, k] * matrix[k, j];
                result[i, j] = Math.Round(sum, 2);
            }

        return result;
    }
}
