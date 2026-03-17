using System;

/// <summary>
/// Class containing vector math utility methods.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates and returns the magnitude (length) of a given vector.
    /// </summary>
    /// <param name="vector">The vector as a double array (2D or 3D).</param>
    /// <returns>The magnitude rounded to the nearest hundredth, or -1 if not 2D or 3D.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
            return -1;

        double sumOfSquares = 0;
        foreach (double component in vector)
            sumOfSquares += component * component;

        return Math.Round(Math.Sqrt(sumOfSquares), 2);
    }
}
