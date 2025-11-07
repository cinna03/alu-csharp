using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie with public health and validated constructors.
    /// </summary>
    public class Zombie
    {
        /// <summary>Health of the zombie.</summary>
        public int health;

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
    }
}
