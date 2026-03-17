using System;

/// <summary>
/// Class containing matrix math utility methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix by a given shear factor in either the X or Y direction.
    /// </summary>
    /// <param name="matrix">The 2x2 matrix to shear.</param>
    /// <param name="direction">The shear direction: 'x' or 'y'.</param>
    /// <param name="factor">The shear factor.</param>
    /// <returns>The sheared matrix, or a matrix containing -1 if invalid input.</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix == null)
            return new double[,] { { -1 } };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2)
            return new double[,] { { -1 } };

        if (direction != 'x' && direction != 'y')
            return new double[,] { { -1 } };

        double[,] result = new double[2, 2];

        if (direction == 'x')
        {
            // Shear X matrix: [[1, s], [0, 1]]
            // Result = [[1, s], [0, 1]] * matrix
            result[0, 0] = Math.Round(matrix[0, 0] + factor * matrix[1, 0], 2);
            result[0, 1] = Math.Round(matrix[0, 1] + factor * matrix[1, 1], 2);
            result[1, 0] = Math.Round(matrix[1, 0], 2);
            result[1, 1] = Math.Round(matrix[1, 1], 2);
        }
        else
        {
            // Shear Y matrix: [[1, 0], [s, 1]]
            // Result = [[1, 0], [s, 1]] * matrix
            result[0, 0] = Math.Round(matrix[0, 0], 2);
            result[0, 1] = Math.Round(matrix[0, 1], 2);
            result[1, 0] = Math.Round(factor * matrix[0, 0] + matrix[1, 0], 2);
            result[1, 1] = Math.Round(factor * matrix[0, 1] + matrix[1, 1], 2);
        }

        return result;
    }
}
