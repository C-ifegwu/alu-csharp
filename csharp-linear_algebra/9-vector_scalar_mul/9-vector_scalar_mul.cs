using System;

/// <summary>
/// Class containing vector math methods.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar and returns the resulting vector.
    /// </summary>
    /// <param name="vector">A 2D or 3D vector.</param>
    /// <param name="scalar">A scalar value to multiply with.</param>
    /// <returns>The resulting vector, or a vector containing -1 if the input is invalid.</returns>
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
