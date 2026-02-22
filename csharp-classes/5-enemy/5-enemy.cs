using System;

namespace Enemies
{
    /// <summary>Defines a zombie enemy with a custom ToString representation.</summary>
    public class Zombie
    {
        private int health;
        private string name = "(No name)";

        /// <summary>Gets or sets the zombie's name.</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

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

        /// <summary>Returns the zombie's current health.</summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>Returns a string representation of the Zombie.</summary>
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
