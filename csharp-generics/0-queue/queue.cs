using System;

/// <summary>
/// A minimal generic queue placeholder used to demonstrate generics.
/// </summary>
/// <typeparam name="T">The type stored by the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Returns the <see cref="Type"/> for the generic parameter <c>T</c>.
    /// </summary>
    /// <returns>The runtime <see cref="Type"/> for <c>T</c>.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
