using System;

/// <summary>
/// Class containing vector math methods.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the cross product of two 3D vectors.
    /// </summary>
    /// <param name="vector1">First 3D vector.</param>
    /// <param name="vector2">Second 3D vector.</param>
    /// <returns>The cross product vector rounded to the nearest hundredth, or a vector containing -1 if inputs are invalid.</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1 == null || vector2 == null)
            return new double[] { -1 };

        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[] { -1 };

        double[] result = new double[3];
        result[0] = Math.Round(vector1[1] * vector2[2] - vector1[2] * vector2[1], 2);
        result[1] = Math.Round(vector1[2] * vector2[0] - vector1[0] * vector2[2], 2);
        result[2] = Math.Round(vector1[0] * vector2[1] - vector1[1] * vector2[0], 2);

        return result;
    }
}
