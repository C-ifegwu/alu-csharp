using System;

/// <summary>
/// Shape class
/// </summary>
public class Shape
{
    /// <summary>
    /// Area of shape
    /// </summary>
    /// <returns>Throws NotImplementedException</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle class
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Width property
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    /// <summary>
    /// Height property
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
}
