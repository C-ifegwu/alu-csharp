using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie enemy with a health field.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// The health of the zombie.
        /// </summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with health set to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
    }
}
