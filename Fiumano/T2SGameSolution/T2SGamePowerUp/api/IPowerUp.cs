using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T2SGamePowerUp.api
{
    /// <summary>
    /// functional interface that represents a power up.
    /// </summary>
    public interface IPowerUp 
    {
        /// <summary>
        /// method called to obtain/gain a power up.
        /// </summary>
        /// <param name="entity">entity that receives the power up</param>
        void Obtain(Entity entity);
    }
}