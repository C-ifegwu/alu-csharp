using System;

/// <summary>
/// Class containing matrix math methods.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix by a given factor in either the X or Y direction.
    /// </summary>
    /// <param name="matrix">A square 2D matrix (2x2).</param>
    /// <param name="direction">The shear direction: 'x' or 'y'.</param>
    /// <param name="factor">The shear factor.</param>
    /// <returns>The sheared matrix, or a matrix containing -1 if inputs are invalid.</returns>
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

        double[,] shearMatrix;

        if (direction == 'x')
        {
            // Shear in X: [[1, factor], [0, 1]]
            shearMatrix = new double[,]
            {
                { 1, factor },
                { 0, 1 }
            };
        }
        else
        {
            // Shear in Y: [[1, 0], [factor, 1]]
            shearMatrix = new double[,]
            {
                { 1, 0 },
                { factor, 1 }
            };
        }

        double[,] result = new double[2, 2];
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
            {
                double sum = 0;
                for (int k = 0; k < 2; k++)
                    sum += shearMatrix[i, k] * matrix[k, j];
                result[i, j] = Math.Round(sum, 2);
            }

        return result;
    }
}
