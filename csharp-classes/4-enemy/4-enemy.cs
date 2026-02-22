using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie enemy with health and a name.
    /// </summary>
    public class Zombie
    {
        // Private field storing the zombie's health
        private int health;

        // Private field storing the zombie's name, default is "(No name)"
        private string name = "(No name)";

        /// <summary>
        /// Gets or sets the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with health set to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with specified health.
        /// </summary>
        /// <param name="value">The initial health value. Must be greater than or equal to 0.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="value"/> is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /// <summary>
        /// Gets the current health of the zombie.
        /// </summary>
        /// <returns>The zombie's current health value.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
