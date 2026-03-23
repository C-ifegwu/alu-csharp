using System;

/// <summary>
/// Class containing vector math methods.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1">First 2D or 3D vector.</param>
    /// <param name="vector2">Second 2D or 3D vector.</param>
    /// <returns>The sum vector, or a vector containing -1 if inputs are invalid.</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1 == null || vector2 == null)
            return new double[] { -1 };

        if ((vector1.Length != 2 && vector1.Length != 3) ||
            (vector2.Length != 2 && vector2.Length != 3) ||
            vector1.Length != vector2.Length)
            return new double[] { -1 };

        double[] result = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
            result[i] = vector1[i] + vector2[i];

        return result;
    }
}
