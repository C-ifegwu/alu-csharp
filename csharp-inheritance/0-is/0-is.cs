using System;
using System.Collections.Generic;

/// <summary>
/// Obj class.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if object is an int.
    /// </summary>
    /// <param name="obj">The object to check</param>
    /// <returns>True if the object is an int, otherwise False</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
