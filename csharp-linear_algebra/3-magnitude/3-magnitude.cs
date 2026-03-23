using System;

/// <summary>
/// Class containing vector math methods.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates and returns the magnitude (length) of a given vector.
    /// </summary>
    /// <param name="vector">A double array representing a 2D or 3D vector.</param>
    /// <returns>The magnitude of the vector rounded to the nearest hundredth, or -1 if invalid.</returns>
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
