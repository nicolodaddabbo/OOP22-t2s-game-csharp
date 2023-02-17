using System.Collections.Generic;

namespace T2SGame
{   /// <summary>
    /// interface describing a PowerUp factory.
    /// </summary>
    public interface IPowerUpFactory 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>a damage up PowerUp</returns>
        IPowerUp GenerateDamageBoostPowerUp();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>a fire ratio up PowerUp</returns>
        IPowerUp GenerateFireRatioPowerUp();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>a health up PowerUp</returns>
        IPowerUp GenerateHealthUpPowerUp();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>a speed up PowerUp</returns>
        IPowerUp GenerateSpeedUpPowerUp();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>a projectile speed up PowerUp</returns>
        IPowerUp GenerateProjectileSpeedUpPowerUp();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>a projectile size up PowerUp</returns>
        IPowerUp GenerateProjectileSizeUpPowerUp();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>a list of all obtainable power ups</returns>
        List<IPowerUp> GetObtainablePowerUpList();
    }
}