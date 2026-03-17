using System;

/// <summary>
/// Class containing matrix math utility methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle (in radians) and returns the resulting matrix.
    /// Rotation is applied to the value of each element, not to the positions.
    /// </summary>
    /// <param name="matrix">The 2x2 matrix to rotate.</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>The rotated matrix, or a matrix containing -1 if invalid input.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null)
            return new double[,] { { -1 } };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2)
            return new double[,] { { -1 } };

        double cosA = Math.Cos(angle);
        double sinA = Math.Sin(angle);

        // Rotation matrix R = [[cos, -sin], [sin, cos]]
        // Result = R * matrix
        double[,] result = new double[2, 2];
        result[0, 0] = Math.Round(cosA * matrix[0, 0] + (-sinA) * matrix[1, 0], 2);
        result[0, 1] = Math.Round(cosA * matrix[0, 1] + (-sinA) * matrix[1, 1], 2);
        result[1, 0] = Math.Round(sinA * matrix[0, 0] + cosA * matrix[1, 0], 2);
        result[1, 1] = Math.Round(sinA * matrix[0, 1] + cosA * matrix[1, 1], 2);

        return result;
    }
}
