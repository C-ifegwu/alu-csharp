using System;

/// <summary>
/// Shape class
/// </summary>
class Shape
{
    /// <summary>
    /// Area of shape
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle class
/// </summary>
class Rectangle : Shape
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

    /// <summary>
    /// Area of rectangle
    /// </summary>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// ToString representation
    /// </summary>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

/// <summary>
/// Square class
/// </summary>
class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Size property
    /// </summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            size = value;
            Width = value;
            Height = value;
        }
    }

    /// <summary>
    /// ToString representation
    /// </summary>
    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}
