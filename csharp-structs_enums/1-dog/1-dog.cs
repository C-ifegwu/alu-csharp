using System;

/// <summary>
/// Enumeration for dog ratings
/// </summary>
enum Rating
{
    /// <summary>Good rating</summary>
    Good,
    /// <summary>Great rating</summary>
    Great,
    /// <summary>Excellent rating</summary>
    Excellent
}

/// <summary>
/// Struct representing a Dog
/// </summary>
struct Dog
{
    /// <summary>Dog's name</summary>
    public string name;
    
    /// <summary>Dog's age</summary>
    public float age;
    
    /// <summary>Dog's owner</summary>
    public string owner;
    
    /// <summary>Dog's rating</summary>
    public Rating rating;
}
