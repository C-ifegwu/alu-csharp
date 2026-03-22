using System;

/// <summary>
/// Class containing vector math utility methods.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar and returns the resulting vector.
    /// </summary>
    /// <param name="vector">The vector (2D or 3D).</param>
    /// <param name="scalar">The scalar value to multiply by.</param>
    /// <returns>The resulting vector, or a vector containing -1 if invalid input.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
            return new double[] { -1 };

        double[] result = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
            result[i] = Math.Round(vector[i] * scalar, 2);

        return result;
    }
}
