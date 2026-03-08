# Understanding Liskov Substitution Principle: Why a Square is not always a Rectangle

When designing object-oriented systems, it is tempting to model inheritance hierarchies based on our real-world understanding of taxonomy. A very common example is modeling shapes. In geometry, every square is a rectangle (a rectangle with equal sides). Therefore, it seems perfectly logical to create a `Rectangle` base class and derive a `Square` class from it.

However, in software engineering, this seemingly intuitive relationship violates a core tenet of object-oriented design: **The Liskov Substitution Principle (LSP)**.

## What is Liskov Substitution Principle?

Introduced by Barbara Liskov in 1987, LSP is the "L" in the SOLID design principles. It states that objects of a superclass shall be replaceable with objects of its subclasses without breaking the application.

In simpler terms: if a program works with a Base Class, it should work identically when a subclass is substituted. The subclass must strictly honor the contract established by the base class.

![Liskov Substitution Principle](https://miro.medium.com/max/1200/1*C605q2aI8S8_dhyEqw_wMw.png)

## Why Square Inheriting From Rectangle Fails LSP

Let's look at the contract of a `Rectangle`. It has two independent properties: `Width` and `Height`.

```csharp
Rectangle rect = new Rectangle();
rect.Width = 5;
rect.Height = 10;
// We expect Width to be 5, Height to be 10, Area to be 50.
```

When we create a `Square` subclass, we are forced to constrain its behavior. To ensure a square remains a square, setting the `Width` must also change the `Height`, or setting the `Size` must change both.

```csharp
Square sq = new Square();
sq.Width = 5;
sq.Height = 10; // This violates the square's geometry!
```

If our application has a function that accepts a `Rectangle` and resizes it, assuming height and width are independent, substituting a `Square` into that function will result in unexpected behavior:

```csharp
void ResizeRectangle(Rectangle r) 
{
    r.Width = 4;
    r.Height = 5;
    // Expected area: 20
    // If r is a Square, changing Height to 5 also changed Width to 5. Actual area: 25!
}
```

Because the `Square` breaks the behavioral expectations of the `Rectangle` class, it fails the Liskov Substitution Principle. The relationship fails because a square doesn't require *more* definitions than a rectangle, it requires *stricter constraints*.

## Improving the Class Hierarchy

To solve this we must rethink our hierarchy. Inheritance is an "is a" relationship *of behaviors*, not taxonomy. Instead of trying to force Square into a Rectangle mold, both should inherit from a common abstraction that doesn't enforce independent width and height.

### Alternative 1: Common Base Interface / Abstract Class
Make a `Shape` base class or interface. Let both `Rectangle` and `Square` implement it independently.

```csharp
public abstract class Shape 
{
    public abstract int Area();
}

public class Rectangle : Shape 
{
    public int Width { get; set; }
    public int Height { get; set; }
    public override int Area() => Width * Height;
}

public class Square : Shape 
{
    public int Size { get; set; }
    public override int Area() => Size * Size;
}
```
Now, code that expects a `Shape` simply relies on getting the `Area()`, without assuming independent width/height properties.

### Conclusion

Modeling inheritance strictly on real-world geometry is a common pitfall. Always focus on **behavioral contracts**. If a derived class cannot satisfy the expectations placed on the base class, it should not inherit from it. Designing with the Liskov Substitution Principle guarantees scalable, robust, and cleanly abstracted systems!
