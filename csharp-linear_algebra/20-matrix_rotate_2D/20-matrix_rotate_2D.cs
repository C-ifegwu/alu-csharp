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
    /// <param name="matrix">The square 2x2 or 3x3 matrix to rotate.</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>The rotated matrix, or a matrix containing -1 if invalid input.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null)
            return new double[,] { { -1 } };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Must be a square matrix of size 2 or 3
        if (rows != cols || (rows != 2 && rows != 3))
            return new double[,] { { -1 } };

        double cosA = Math.Cos(angle);
        double sinA = Math.Sin(angle);

        double[,] result = new double[rows, cols];

        if (rows == 2)
        {
            // R = [[cos, -sin], [sin, cos]], result = R * matrix
            result[0, 0] = Math.Round(cosA * matrix[0, 0] + (-sinA) * matrix[1, 0], 2);
            result[0, 1] = Math.Round(cosA * matrix[0, 1] + (-sinA) * matrix[1, 1], 2);
            result[1, 0] = Math.Round(sinA * matrix[0, 0] + cosA * matrix[1, 0], 2);
            result[1, 1] = Math.Round(sinA * matrix[0, 1] + cosA * matrix[1, 1], 2);
        }
        else // rows == 3
        {
            // Extended 3x3 rotation matrix
            double[,] rotMat = {
                { cosA, -sinA, 0 },
                { sinA,  cosA, 0 },
                { 0,     0,    1 }
            };
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < 3; k++)
                        sum += rotMat[i, k] * matrix[k, j];
                    result[i, j] = Math.Round(sum, 2);
                }
        }

        return result;
    }
}
