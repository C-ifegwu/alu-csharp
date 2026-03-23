using System;

/// <summary>
/// Class containing vector math methods.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two 2D or 3D vectors.
    /// </summary>
    /// <param name="vector1">First 2D or 3D vector.</param>
    /// <param name="vector2">Second 2D or 3D vector.</param>
    /// <returns>The dot product rounded to the nearest hundredth, or -1 if inputs are invalid.</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1 == null || vector2 == null)
            return -1;

        if ((vector1.Length != 2 && vector1.Length != 3) ||
            (vector2.Length != 2 && vector2.Length != 3) ||
            vector1.Length != vector2.Length)
            return -1;

        double result = 0;
        for (int i = 0; i < vector1.Length; i++)
            result += vector1[i] * vector2[i];

        return Math.Round(result, 2);
    }
}
