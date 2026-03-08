using System;

/// <summary>
/// Obj class.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the object is an instance of a class that inherits from the specified class.
    /// </summary>
    /// <param name="derivedType">The derived type</param>
    /// <param name="baseType">The base type</param>
    /// <returns>True if it is only a subclass, false otherwise</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
