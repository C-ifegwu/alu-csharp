using System;

/// <summary>
/// Shape class.
/// </summary>
public class Shape
{
    /// <summary>
    /// Area of shape.
    /// </summary>
    /// <returns>Throws NotImplementedException</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
