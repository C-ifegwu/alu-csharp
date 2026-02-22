using System;

namespace Enemies
{
    /// <summary>Defines a zombie enemy with validated health.</summary>
    public class Zombie
    {
        /// <summary>The zombie's health points.</summary>
        public int health;

        /// <summary>Initializes a new Zombie with 0 health.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Initializes a new Zombie with the given health value.</summary>
        /// <param name="value">Health value; must be >= 0.</param>
        /// <exception cref="ArgumentException">Thrown when value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
    }
}
