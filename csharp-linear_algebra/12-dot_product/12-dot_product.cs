using System;

/// <summary>
/// Class containing vector math utility methods.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two vectors (both 2D or both 3D).
    /// </summary>
    /// <param name="vector1">The first vector (2D or 3D).</param>
    /// <param name="vector2">The second vector (2D or 3D).</param>
    /// <returns>The dot product, or -1 if invalid input.</returns>
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

        return result;
    }
}
