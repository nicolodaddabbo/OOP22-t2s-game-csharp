using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T2SGame
{   ///<summary>
    /// Class that represents a Health component 
    ///</summary> 
    public class HealthComponent : AbstractComponent
    {
        public HealthComponent(int health)
        {
            Health = health;
        }

        public int Health { get; set; }

        /// <inheritdoc />
        public override void Receive<T>(IMessageFunc<T> message)
        {
            if (message() is int damage)
            {
                Health -= damage;
                if (Health < 0)
                    Health = 0;
            }
        }

        /// <inheritdoc />
        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}