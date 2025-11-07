using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie with a public health field.
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
    }
}
