using System;
using System.Linq.Expressions;

namespace Enemies
{
    /// <summary>
    /// This is a class that represent zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Represent the health of a zombie.
        /// </summary>
        private int health;

        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        public int GetHealth()
        {
            return health;
        }
    }
}
