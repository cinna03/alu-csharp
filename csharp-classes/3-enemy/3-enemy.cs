using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie with private health and accessors.
    /// </summary>
    public class Zombie
    {
        private int health;

        /// <summary>Initializes a new Zombie with 0 health.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Initializes a new Zombie with the specified health.</summary>
        /// <param name="value">Health value (must be >= 0).</param>
        /// <exception cref="ArgumentException">Thrown when value is negative.</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /// <summary>Returns the current health.</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
