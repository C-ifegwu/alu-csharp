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

    /// <summary>
    /// Constructor for Dog struct
    /// </summary>
    /// <param name="name">Dog's name</param>
    /// <param name="age">Dog's age</param>
    /// <param name="owner">Dog's owner</param>
    /// <param name="rating">Dog's rating</param>
    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }
}
