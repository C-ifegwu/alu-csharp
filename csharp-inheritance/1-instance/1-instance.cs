using System;

/// <summary>
/// Obj class.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if the object is an instance of, or if the object is an instance of a class that inherited from, Array.
    /// </summary>
    /// <param name="obj">The object to check</param>
    /// <returns>True if object is an Array or inherits from Array, otherwise False</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
